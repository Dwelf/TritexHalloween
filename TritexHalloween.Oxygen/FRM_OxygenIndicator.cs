using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TritexHalloween.Oxygen
{
    public partial class FRM_OxygenIndicator : Form
    {
        public FRM_OxygenIndicator()
        {
            InitializeComponent();
        }

        private void FRM_OxygenIndicator_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(0, 0);
            this.TopMost = true;
            Screen currentScreen = Screen.FromHandle(this.Handle);
            this.Size = new System.Drawing.Size(currentScreen.Bounds.Width, currentScreen.Bounds.Height);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_OxygenRemaning_Click(object sender, EventArgs e)
        {

        }
    }
}
