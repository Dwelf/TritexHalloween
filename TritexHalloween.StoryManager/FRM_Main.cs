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
            adventurer.OxygenRemaining = decimal.Parse(txt_Oxygen.Text);
            adventurer.SuitPressure = decimal.Parse(txt_Pressure.Text);
            Enum.TryParse(lb_HeartRate.SelectedItem.ToString(), out HeartRateMode hr);
            adventurer.HeartRateMode = hr;
            client.Send(0, adventurer);
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            var statusSetter = new SetStatus { NewStatus = txb_StatusSetter.Text };
            client.Send(3, statusSetter);
        }

        private void btn_setSuitPressure_Click(object sender, EventArgs e)
        {
            var statusSetter = new SetSuitPressure { NewPressure = decimal.Parse(txb_SuitPressureSetter.Text) };
            client.Send(4, statusSetter);
        }

        private void btn_heartRate_Click(object sender, EventArgs e)
        {
            Enum.TryParse(lb_HeartRateSetter.SelectedItem.ToString(), out HeartRateMode hr);
            var statusSetter = new SetHeatRate() { NewHeartRateMode = hr };
            client.Send(1, statusSetter);
        }

        private void btn_AffectOxygen_Click(object sender, EventArgs e)
        {
            var affectOxygen = new SetOxygen() { NewOxygen = decimal.Parse(txt_OxygenSetter.Text) };
            client.Send(2, affectOxygen);
        }

        private void btn_settemperature_Click(object sender, EventArgs e)
        {
            var tempSetter = new SetTemperature() { NewTemperature = decimal.Parse(txt_TemperatureSetter.Text) };
            client.Send(5, tempSetter);
        }
    }
}
