using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TritexHalloween.Oxygen
{
    using System.IO;
    using System.Net;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    using TritexHalloween.Networking;
    using TritexHalloween.StoryObjects;

    public partial class FRM_OxygenIndicator : Form
    {
        private IPAddress ip;

        private Adventurer adventurer;

        public FRM_OxygenIndicator(string ip)
        {
            this.ip = IPAddress.Parse(ip);

            InitializeComponent();
            Server.RunWorkerAsync();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered(lb_heartrate, true);
            DoubleBuffered(lb_oxygen, true);
            DoubleBuffered(TLP_Main, true);

        }

        private void FRM_OxygenIndicator_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //this.Location = new Point(0, 0);
            //this.TopMost = true;
            //Screen currentScreen = Screen.FromHandle(this.Handle);
            //this.Size = new System.Drawing.Size(currentScreen.Bounds.Width, currentScreen.Bounds.Height);
        }

        private void Server_DoWork(object sender, DoWorkEventArgs e)
        {
            var server = new Server(ip, UpdateAdventurer);
            server.Start();
        }

        private void UpdateAdventurer(Message message)
        {
            IFormatter formatter;
            switch (message.ObjectType)
            {
                default:
                case 0:
                    using (var stream = new MemoryStream(message.Data))
                    {
                        formatter = new BinaryFormatter();
                        var adv = (Adventurer)formatter.Deserialize(stream);
                        Invoke((MethodInvoker)delegate
                        {
                            SetAdventurer(adv);
                            AddMessage("Satellite link established...");
                        });
                    }
                    break;
                case 1: // heart Rate
                    using (var stream = new MemoryStream(message.Data))
                    {
                        formatter = new BinaryFormatter();
                        var heatRate = (SetHeatRate)formatter.Deserialize(stream);
                        Invoke((MethodInvoker)delegate
                        {
                            adventurer.HeartRateMode = heatRate.NewHeartRateMode;
                            SetAdventurer(adventurer);
                            lb_heartrate.Parent.SuspendLayout();
                            switch (adventurer.HeartRateMode)
                            {
                                case HeartRateMode.Green:
                                    lb_heartrate.ForeColor = Color.LawnGreen;
                                    break;
                                case HeartRateMode.Yellow:
                                    lb_heartrate.ForeColor = Color.Yellow;
                                    break;
                                case HeartRateMode.Red:
                                    lb_heartrate.ForeColor = Color.Red;
                                    break;
                            }
                            lb_heartrate.ResumeLayout();
                        });
                    }
                    break;
                case 2: // oxygen
                    using (var stream = new MemoryStream(message.Data))
                    {
                        formatter = new BinaryFormatter();
                        var oxygen = (SetOxygen)formatter.Deserialize(stream);
                        Invoke((MethodInvoker)delegate
                        {
                            adventurer.OxygenRemaining = adventurer.OxygenRemaining.Subtract(TimeSpan.FromMinutes(Convert.ToDouble(oxygen.NewOxygen)));
                        });
                    }
                    break;
                case 3: // status
                    using (var stream = new MemoryStream(message.Data))
                    {
                        formatter = new BinaryFormatter();
                        var setStatus = (SetStatus)formatter.Deserialize(stream);
                        Invoke((MethodInvoker)delegate
                        {
                            adventurer.Status = setStatus.NewStatus;
                            SetAdventurer(adventurer);
                            
                        });
                    }
                    break;
                case 4: // suit pressure
                    using (var stream = new MemoryStream(message.Data))
                    {
                        formatter = new BinaryFormatter();
                        var setSuitPressure = (SetSuitPressure)formatter.Deserialize(stream);
                        Invoke((MethodInvoker)delegate
                        {
                            adventurer.SuitPressure = setSuitPressure.NewPressure;
                            SetAdventurer(adventurer);
                        });
                    }
                    break;
                case 5: // temperature
                    using (var stream = new MemoryStream(message.Data))
                    {
                        formatter = new BinaryFormatter();
                        var setTemperature = (SetTemperature)formatter.Deserialize(stream);
                        Invoke((MethodInvoker)delegate
                        {
                            adventurer.Temperature = setTemperature.NewTemperature;
                            SetAdventurer(adventurer);
                        });
                    }
                    break;
                case 6:
                    using (var stream = new MemoryStream(message.Data))
                    {
                        formatter = new BinaryFormatter();
                        var setTemperature = (Breach)formatter.Deserialize(stream);
                        Invoke((MethodInvoker)delegate
                            {
                                adventurer.OxygenRemaining = adventurer.OxygenRemaining.Subtract(TimeSpan.FromSeconds(setTemperature.MinutesLost));
                                AddMessage($"Breach ({setTemperature.MinutesLost}) Minutes of Oxygen lost");
                            });
                    }

                    break;
            }
        }

        private void SetAdventurer(Adventurer adv)
        {
            tmr_respiration.Stop();
            adventurer = adv;
            lb_SubjectValue.Text = adventurer.Name;
            lb_temperature.Text = adventurer.Temperature.ToString("N2") + "C";
            lb_oxygen.Text = adventurer.OxygenRemaining.ToString("N2") + "L";
            lb_StatusValue.Text = adventurer.Status;
            tmr_respiration.Start();
        }

        private void setOxygenHeartRate(double seconds = 1)
        {
            lb_oxygen.Parent.SuspendLayout();
            adventurer.OxygenRemaining = adventurer.OxygenRemaining.Subtract(TimeSpan.FromSeconds(seconds));
            lb_oxygen.Text = adventurer.OxygenRemaining.ToString();
            lb_oxygen.Parent.ResumeLayout();
        }

        private void tmr_respiration_Tick(object sender, EventArgs e)
        {
            setOxygenHeartRate();
        }

        public static void DoubleBuffered(Control formControl, bool setting)
        {
            Type conType = formControl.GetType();
            PropertyInfo pi = conType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(formControl, setting, null);
        }

        private void lb_OxygenRemaning_Click(object sender, EventArgs e)
        {

        }

        private void AddMessage(string message)
        {
            rtb_Events.Text += DateTime.Now.ToShortTimeString() + ": " + message + Environment.NewLine;
        }

        private void lb_HeartRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TLP_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}