namespace TritexHalloween.Oxygen
{
    partial class FRM_OxygenIndicator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_OxygenIndicator));
            this.splc_Main = new System.Windows.Forms.SplitContainer();
            this.splc_Status = new System.Windows.Forms.SplitContainer();
            this.spc_PicStatus = new System.Windows.Forms.SplitContainer();
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lb_oxygen = new System.Windows.Forms.Label();
            this.lb_heartrate = new System.Windows.Forms.Label();
            this.lb_temperature = new System.Windows.Forms.Label();
            this.lb_TemperatureLabel = new System.Windows.Forms.Label();
            this.lb_HeartRateLabel = new System.Windows.Forms.Label();
            this.lb_OxygenRemaning = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_StatusValue = new System.Windows.Forms.Label();
            this.rtb_Events = new System.Windows.Forms.RichTextBox();
            this.Server = new System.ComponentModel.BackgroundWorker();
            this.tmr_respiration = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_SubjectName = new System.Windows.Forms.Label();
            this.lb_SubjectValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splc_Main)).BeginInit();
            this.splc_Main.Panel1.SuspendLayout();
            this.splc_Main.Panel2.SuspendLayout();
            this.splc_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splc_Status)).BeginInit();
            this.splc_Status.Panel1.SuspendLayout();
            this.splc_Status.Panel2.SuspendLayout();
            this.splc_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_PicStatus)).BeginInit();
            this.spc_PicStatus.Panel2.SuspendLayout();
            this.spc_PicStatus.SuspendLayout();
            this.TLP_Main.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splc_Main
            // 
            this.splc_Main.BackColor = System.Drawing.Color.Transparent;
            this.splc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splc_Main.Location = new System.Drawing.Point(0, 0);
            this.splc_Main.Name = "splc_Main";
            this.splc_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splc_Main.Panel1
            // 
            this.splc_Main.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splc_Main.Panel1.Controls.Add(this.splc_Status);
            // 
            // splc_Main.Panel2
            // 
            this.splc_Main.Panel2.Controls.Add(this.rtb_Events);
            this.splc_Main.Size = new System.Drawing.Size(1530, 862);
            this.splc_Main.SplitterDistance = 743;
            this.splc_Main.SplitterWidth = 1;
            this.splc_Main.TabIndex = 0;
            // 
            // splc_Status
            // 
            this.splc_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splc_Status.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splc_Status.IsSplitterFixed = true;
            this.splc_Status.Location = new System.Drawing.Point(0, 0);
            this.splc_Status.Name = "splc_Status";
            this.splc_Status.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splc_Status.Panel1
            // 
            this.splc_Status.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splc_Status.Panel2
            // 
            this.splc_Status.Panel2.Controls.Add(this.spc_PicStatus);
            this.splc_Status.Size = new System.Drawing.Size(1530, 743);
            this.splc_Status.SplitterDistance = 65;
            this.splc_Status.SplitterWidth = 1;
            this.splc_Status.TabIndex = 0;
            // 
            // spc_PicStatus
            // 
            this.spc_PicStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_PicStatus.Location = new System.Drawing.Point(0, 0);
            this.spc_PicStatus.Name = "spc_PicStatus";
            // 
            // spc_PicStatus.Panel1
            // 
            this.spc_PicStatus.Panel1.BackColor = System.Drawing.Color.Black;
            this.spc_PicStatus.Panel1.BackgroundImage = global::TritexHalloween.Oxygen.Properties.Resources.SpinningMan;
            this.spc_PicStatus.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // spc_PicStatus.Panel2
            // 
            this.spc_PicStatus.Panel2.Controls.Add(this.TLP_Main);
            this.spc_PicStatus.Size = new System.Drawing.Size(1530, 677);
            this.spc_PicStatus.SplitterDistance = 824;
            this.spc_PicStatus.TabIndex = 0;
            // 
            // TLP_Main
            // 
            this.TLP_Main.AutoSize = true;
            this.TLP_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TLP_Main.ColumnCount = 2;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Main.Controls.Add(this.lb_oxygen, 1, 2);
            this.TLP_Main.Controls.Add(this.lb_heartrate, 1, 1);
            this.TLP_Main.Controls.Add(this.lb_temperature, 1, 3);
            this.TLP_Main.Controls.Add(this.lb_TemperatureLabel, 0, 3);
            this.TLP_Main.Controls.Add(this.lb_HeartRateLabel, 0, 1);
            this.TLP_Main.Controls.Add(this.lb_OxygenRemaning, 0, 2);
            this.TLP_Main.Controls.Add(this.lb_Status, 0, 0);
            this.TLP_Main.Controls.Add(this.lb_StatusValue, 1, 0);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 4;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Main.Size = new System.Drawing.Size(702, 677);
            this.TLP_Main.TabIndex = 2;
            this.TLP_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.TLP_Main_Paint);
            // 
            // lb_oxygen
            // 
            this.lb_oxygen.AutoSize = true;
            this.lb_oxygen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_oxygen.Font = new System.Drawing.Font("Consolas", 30F);
            this.lb_oxygen.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_oxygen.Location = new System.Drawing.Point(354, 338);
            this.lb_oxygen.Name = "lb_oxygen";
            this.lb_oxygen.Size = new System.Drawing.Size(345, 169);
            this.lb_oxygen.TabIndex = 9;
            // 
            // lb_heartrate
            // 
            this.lb_heartrate.AutoSize = true;
            this.lb_heartrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_heartrate.Font = new System.Drawing.Font("Arial Narrow", 70F);
            this.lb_heartrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_heartrate.Location = new System.Drawing.Point(354, 169);
            this.lb_heartrate.Name = "lb_heartrate";
            this.lb_heartrate.Size = new System.Drawing.Size(345, 169);
            this.lb_heartrate.TabIndex = 8;
            this.lb_heartrate.Text = "♥";
            this.lb_heartrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_temperature
            // 
            this.lb_temperature.AutoSize = true;
            this.lb_temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_temperature.Font = new System.Drawing.Font("Consolas", 30F);
            this.lb_temperature.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_temperature.Location = new System.Drawing.Point(354, 507);
            this.lb_temperature.Name = "lb_temperature";
            this.lb_temperature.Size = new System.Drawing.Size(345, 170);
            this.lb_temperature.TabIndex = 6;
            // 
            // lb_TemperatureLabel
            // 
            this.lb_TemperatureLabel.AutoSize = true;
            this.lb_TemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TemperatureLabel.Font = new System.Drawing.Font("Consolas", 35F);
            this.lb_TemperatureLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_TemperatureLabel.Location = new System.Drawing.Point(3, 507);
            this.lb_TemperatureLabel.Name = "lb_TemperatureLabel";
            this.lb_TemperatureLabel.Size = new System.Drawing.Size(345, 170);
            this.lb_TemperatureLabel.TabIndex = 1;
            this.lb_TemperatureLabel.Text = "Temp:";
            this.lb_TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_HeartRateLabel
            // 
            this.lb_HeartRateLabel.AutoSize = true;
            this.lb_HeartRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_HeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HeartRateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_HeartRateLabel.Location = new System.Drawing.Point(3, 169);
            this.lb_HeartRateLabel.Name = "lb_HeartRateLabel";
            this.lb_HeartRateLabel.Size = new System.Drawing.Size(345, 169);
            this.lb_HeartRateLabel.TabIndex = 3;
            this.lb_HeartRateLabel.Text = "Heart Status";
            this.lb_HeartRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_OxygenRemaning
            // 
            this.lb_OxygenRemaning.AutoSize = true;
            this.lb_OxygenRemaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_OxygenRemaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lb_OxygenRemaning.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_OxygenRemaning.Location = new System.Drawing.Point(3, 338);
            this.lb_OxygenRemaning.Name = "lb_OxygenRemaning";
            this.lb_OxygenRemaning.Size = new System.Drawing.Size(345, 169);
            this.lb_OxygenRemaning.TabIndex = 4;
            this.lb_OxygenRemaning.Text = "Oxygen:";
            this.lb_OxygenRemaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lb_Status.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_Status.Location = new System.Drawing.Point(3, 0);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(345, 169);
            this.lb_Status.TabIndex = 10;
            this.lb_Status.Text = "Status";
            this.lb_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_StatusValue
            // 
            this.lb_StatusValue.AutoSize = true;
            this.lb_StatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_StatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lb_StatusValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_StatusValue.Location = new System.Drawing.Point(354, 0);
            this.lb_StatusValue.Name = "lb_StatusValue";
            this.lb_StatusValue.Size = new System.Drawing.Size(345, 169);
            this.lb_StatusValue.TabIndex = 11;
            // 
            // rtb_Events
            // 
            this.rtb_Events.BackColor = System.Drawing.Color.Black;
            this.rtb_Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Events.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Events.ForeColor = System.Drawing.Color.Green;
            this.rtb_Events.Location = new System.Drawing.Point(0, 0);
            this.rtb_Events.Name = "rtb_Events";
            this.rtb_Events.ReadOnly = true;
            this.rtb_Events.Size = new System.Drawing.Size(1530, 118);
            this.rtb_Events.TabIndex = 0;
            this.rtb_Events.Text = "";
            // 
            // Server
            // 
            this.Server.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Server_DoWork);
            // 
            // tmr_respiration
            // 
            this.tmr_respiration.Interval = 1000;
            this.tmr_respiration.Tick += new System.EventHandler(this.tmr_respiration_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lb_SubjectName);
            this.flowLayoutPanel1.Controls.Add(this.lb_SubjectValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1530, 65);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lb_SubjectName
            // 
            this.lb_SubjectName.AutoSize = true;
            this.lb_SubjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SubjectName.Font = new System.Drawing.Font("Consolas", 40F);
            this.lb_SubjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_SubjectName.Location = new System.Drawing.Point(3, 0);
            this.lb_SubjectName.Name = "lb_SubjectName";
            this.lb_SubjectName.Size = new System.Drawing.Size(268, 64);
            this.lb_SubjectName.TabIndex = 7;
            this.lb_SubjectName.Text = "Subject:";
            this.lb_SubjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_SubjectValue
            // 
            this.lb_SubjectValue.AutoSize = true;
            this.lb_SubjectValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SubjectValue.Font = new System.Drawing.Font("Consolas", 40F);
            this.lb_SubjectValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_SubjectValue.Location = new System.Drawing.Point(277, 0);
            this.lb_SubjectValue.Name = "lb_SubjectValue";
            this.lb_SubjectValue.Size = new System.Drawing.Size(388, 64);
            this.lb_SubjectValue.TabIndex = 8;
            this.lb_SubjectValue.Text = "Subject Name";
            this.lb_SubjectValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FRM_OxygenIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1530, 862);
            this.Controls.Add(this.splc_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_OxygenIndicator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oxgen Indicator";
            this.Load += new System.EventHandler(this.FRM_OxygenIndicator_Load);
            this.splc_Main.Panel1.ResumeLayout(false);
            this.splc_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splc_Main)).EndInit();
            this.splc_Main.ResumeLayout(false);
            this.splc_Status.Panel1.ResumeLayout(false);
            this.splc_Status.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splc_Status)).EndInit();
            this.splc_Status.ResumeLayout(false);
            this.spc_PicStatus.Panel2.ResumeLayout(false);
            this.spc_PicStatus.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_PicStatus)).EndInit();
            this.spc_PicStatus.ResumeLayout(false);
            this.TLP_Main.ResumeLayout(false);
            this.TLP_Main.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splc_Main;
        private System.Windows.Forms.SplitContainer splc_Status;
        private System.ComponentModel.BackgroundWorker Server;
        private System.Windows.Forms.Timer tmr_respiration;
        private System.Windows.Forms.RichTextBox rtb_Events;
        private System.Windows.Forms.SplitContainer spc_PicStatus;
        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.Label lb_oxygen;
        private System.Windows.Forms.Label lb_heartrate;
        private System.Windows.Forms.Label lb_temperature;
        private System.Windows.Forms.Label lb_TemperatureLabel;
        private System.Windows.Forms.Label lb_HeartRateLabel;
        private System.Windows.Forms.Label lb_OxygenRemaning;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_StatusValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lb_SubjectName;
        private System.Windows.Forms.Label lb_SubjectValue;
    }
}

