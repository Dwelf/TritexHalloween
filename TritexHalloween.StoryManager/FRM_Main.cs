using System;
using System.Net;
using System.Windows.Forms;
using TritexHalloween.Networking;
using TritexHalloween.StoryObjects;

namespace TritexHalloween.StoryManager
{
    public partial class FRM_Main : Form
    {
        private Client client;
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            var ip = IPAddress.Parse(txt_IP.Text);
            client = new Client(ip);
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            var adventurer = new Adventurer();
            adventurer.Status = txt_Status.Text;
            adventurer.Name = txt_Name.Text;
            adventurer.Temperature = decimal.Parse(txt_Temperature.Text);
            adventurer.OxygenRemaining = TimeSpan.FromMinutes(int.Parse(txt_Oxygen.Text));
            Enum.TryParse(lb_HeartRate.SelectedItem.ToString(), out HeartRateMode hr);
            adventurer.HeartRateMode = hr;
            var result = client.Send(0, adventurer);
            AddMessage(result);
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            var statusSetter = new SetStatus { NewStatus = txb_StatusSetter.Text };
            client.Send(3, statusSetter);
        }

        private void btn_heartRate_Click(object sender, EventArgs e)
        {
            var hrValue = (HeartRateMode)HeartRateMode.Parse(typeof(HeartRateMode), lb_HeartRateSetter.SelectedItem.ToString());


            var statusSetter = new SetHeatRate() { NewHeartRateMode = hrValue };
            var result = client.Send(1, statusSetter);
            AddMessage(result);
        }

        private void btn_AffectOxygen_Click(object sender, EventArgs e)
        {
            var value = DecimalParseString(txt_OxygenSetter.Text);

            if (value == null)
            {
                return;
            }

            var affectOxygen = new SetOxygen() { NewOxygen = value.Value };
            var result = client.Send(2, affectOxygen);
            AddMessage(result);
        }

        private void btn_settemperature_Click(object sender, EventArgs e)
        {
            var value = DecimalParseString(txt_TemperatureSetter.Text);
            if (value == null)
            {
                return;
            }


            var tempSetter = new SetTemperature() { NewTemperature = value.Value };
            var result = client.Send(5, tempSetter) + Environment.NewLine;
            AddMessage(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parsedInt = 0;

            if (int.TryParse(txt_Breach.Text, out parsedInt) == false)
            {
                AddMessage("No value for breach");
            }

            var tempBreach = new TritexHalloween.StoryObjects.Breach(parsedInt);
            var result = client.Send(6, tempBreach);
            AddMessage(result);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddMessage(string message)
        {
            errorBox.Text += DateTime.Now.ToShortTimeString() + ": " + message + Environment.NewLine;
        }

        private decimal? DecimalParseString(string value)
        {
            var parsedDecimal = 0m;

            if (decimal.TryParse(txt_TemperatureSetter.Text, out parsedDecimal) == false)
            {
                AddMessage("Not a recognised value");
                return null;
            }

            return parsedDecimal;
        }

        private int? IntParseString(string value)
        {
            var parsedDecimal = 0;

            if (int.TryParse(txt_TemperatureSetter.Text, out parsedDecimal) == false)
            {
                AddMessage("Not a recognised value");
                return null;
            }

            return parsedDecimal;
        }


    }
}
