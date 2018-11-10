namespace TritexHalloween.StoryManager
{
    partial class FRM_Main
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
            this.tbc_Main = new System.Windows.Forms.TabControl();
            this.tbp_Setup = new System.Windows.Forms.TabPage();
            this.btn_Set = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Temperature = new System.Windows.Forms.TextBox();
            this.txt_Oxygen = new System.Windows.Forms.TextBox();
            this.txt_Pressure = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lb_NameLabel = new System.Windows.Forms.Label();
            this.lb_StatusLabel = new System.Windows.Forms.Label();
            this.lb_SuitPressureLabel = new System.Windows.Forms.Label();
            this.lb_heartRateLabel = new System.Windows.Forms.Label();
            this.lb_OxygenLabel = new System.Windows.Forms.Label();
            this.lb_Temperature = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_HeartRate = new System.Windows.Forms.ListBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.tbp_Status = new System.Windows.Forms.TabPage();
            this.errorBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Breach = new System.Windows.Forms.Button();
            this.btn_settemperature = new System.Windows.Forms.Button();
            this.txt_TemperatureSetter = new System.Windows.Forms.TextBox();
            this.txt_OxygenSetter = new System.Windows.Forms.TextBox();
            this.txb_StatusSetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_HeartRateSetter = new System.Windows.Forms.ListBox();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_heartRate = new System.Windows.Forms.Button();
            this.btn_AffectOxgyen = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Breach = new System.Windows.Forms.TextBox();
            this.tbc_Main.SuspendLayout();
            this.tbp_Setup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbp_Status.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Main
            // 
            this.tbc_Main.Controls.Add(this.tbp_Setup);
            this.tbc_Main.Controls.Add(this.tbp_Status);
            this.tbc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_Main.Location = new System.Drawing.Point(0, 0);
            this.tbc_Main.Name = "tbc_Main";
            this.tbc_Main.SelectedIndex = 0;
            this.tbc_Main.Size = new System.Drawing.Size(800, 642);
            this.tbc_Main.TabIndex = 0;
            // 
            // tbp_Setup
            // 
            this.tbp_Setup.Controls.Add(this.btn_Set);
            this.tbp_Setup.Controls.Add(this.tableLayoutPanel1);
            this.tbp_Setup.Controls.Add(this.btn_connect);
            this.tbp_Setup.Controls.Add(this.txt_IP);
            this.tbp_Setup.Location = new System.Drawing.Point(4, 22);
            this.tbp_Setup.Name = "tbp_Setup";
            this.tbp_Setup.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Setup.Size = new System.Drawing.Size(792, 616);
            this.tbp_Setup.TabIndex = 0;
            this.tbp_Setup.Text = "Setup";
            this.tbp_Setup.UseVisualStyleBackColor = true;
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(453, 345);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 3;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Temperature, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Oxygen, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Pressure, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Status, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_NameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_StatusLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_SuitPressureLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_heartRateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_OxygenLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Temperature, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_HeartRate, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(174, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 339);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txt_Temperature
            // 
            this.txt_Temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Temperature.Location = new System.Drawing.Point(139, 283);
            this.txt_Temperature.Name = "txt_Temperature";
            this.txt_Temperature.Size = new System.Drawing.Size(131, 20);
            this.txt_Temperature.TabIndex = 10;
            // 
            // txt_Oxygen
            // 
            this.txt_Oxygen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Oxygen.Location = new System.Drawing.Point(139, 227);
            this.txt_Oxygen.Name = "txt_Oxygen";
            this.txt_Oxygen.Size = new System.Drawing.Size(131, 20);
            this.txt_Oxygen.TabIndex = 9;
            // 
            // txt_Pressure
            // 
            this.txt_Pressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Pressure.Location = new System.Drawing.Point(139, 115);
            this.txt_Pressure.Name = "txt_Pressure";
            this.txt_Pressure.Size = new System.Drawing.Size(131, 20);
            this.txt_Pressure.TabIndex = 7;
            // 
            // txt_Status
            // 
            this.txt_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Status.Location = new System.Drawing.Point(139, 59);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(131, 20);
            this.txt_Status.TabIndex = 6;
            // 
            // lb_NameLabel
            // 
            this.lb_NameLabel.AutoSize = true;
            this.lb_NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_NameLabel.Location = new System.Drawing.Point(3, 0);
            this.lb_NameLabel.Name = "lb_NameLabel";
            this.lb_NameLabel.Size = new System.Drawing.Size(130, 56);
            this.lb_NameLabel.TabIndex = 0;
            this.lb_NameLabel.Text = "Name";
            // 
            // lb_StatusLabel
            // 
            this.lb_StatusLabel.AutoSize = true;
            this.lb_StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_StatusLabel.Location = new System.Drawing.Point(3, 56);
            this.lb_StatusLabel.Name = "lb_StatusLabel";
            this.lb_StatusLabel.Size = new System.Drawing.Size(130, 56);
            this.lb_StatusLabel.TabIndex = 1;
            this.lb_StatusLabel.Text = "Status";
            // 
            // lb_SuitPressureLabel
            // 
            this.lb_SuitPressureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SuitPressureLabel.Location = new System.Drawing.Point(3, 112);
            this.lb_SuitPressureLabel.Name = "lb_SuitPressureLabel";
            this.lb_SuitPressureLabel.Size = new System.Drawing.Size(130, 56);
            this.lb_SuitPressureLabel.TabIndex = 0;
            this.lb_SuitPressureLabel.Text = "Suit Pressure";
            // 
            // lb_heartRateLabel
            // 
            this.lb_heartRateLabel.AutoSize = true;
            this.lb_heartRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_heartRateLabel.Location = new System.Drawing.Point(3, 168);
            this.lb_heartRateLabel.Name = "lb_heartRateLabel";
            this.lb_heartRateLabel.Size = new System.Drawing.Size(130, 56);
            this.lb_heartRateLabel.TabIndex = 2;
            this.lb_heartRateLabel.Text = "Heart Rate";
            // 
            // lb_OxygenLabel
            // 
            this.lb_OxygenLabel.AutoSize = true;
            this.lb_OxygenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_OxygenLabel.Location = new System.Drawing.Point(3, 224);
            this.lb_OxygenLabel.Name = "lb_OxygenLabel";
            this.lb_OxygenLabel.Size = new System.Drawing.Size(130, 56);
            this.lb_OxygenLabel.TabIndex = 3;
            this.lb_OxygenLabel.Text = "Oxygen(Minutes)";
            // 
            // lb_Temperature
            // 
            this.lb_Temperature.AutoSize = true;
            this.lb_Temperature.Location = new System.Drawing.Point(3, 280);
            this.lb_Temperature.Name = "lb_Temperature";
            this.lb_Temperature.Size = new System.Drawing.Size(67, 13);
            this.lb_Temperature.TabIndex = 4;
            this.lb_Temperature.Text = "Temperature";
            // 
            // txt_Name
            // 
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Name.Location = new System.Drawing.Point(139, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(131, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // lb_HeartRate
            // 
            this.lb_HeartRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_HeartRate.FormattingEnabled = true;
            this.lb_HeartRate.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red"});
            this.lb_HeartRate.Location = new System.Drawing.Point(139, 171);
            this.lb_HeartRate.Name = "lb_HeartRate";
            this.lb_HeartRate.Size = new System.Drawing.Size(131, 50);
            this.lb_HeartRate.TabIndex = 11;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(372, 345);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(170, 347);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(196, 20);
            this.txt_IP.TabIndex = 0;
            // 
            // tbp_Status
            // 
            this.tbp_Status.Controls.Add(this.errorBox);
            this.tbp_Status.Controls.Add(this.tableLayoutPanel2);
            this.tbp_Status.Location = new System.Drawing.Point(4, 22);
            this.tbp_Status.Name = "tbp_Status";
            this.tbp_Status.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Status.Size = new System.Drawing.Size(792, 616);
            this.tbp_Status.TabIndex = 1;
            this.tbp_Status.Text = "Status";
            this.tbp_Status.UseVisualStyleBackColor = true;
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(0, 440);
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(796, 180);
            this.errorBox.TabIndex = 7;
            this.errorBox.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.32365F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.67635F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Breach, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_settemperature, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_TemperatureSetter, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_OxygenSetter, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txb_StatusSetter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lb_HeartRateSetter, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Status, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_heartRate, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_AffectOxgyen, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(176, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(495, 400);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btn_Breach
            // 
            this.btn_Breach.Location = new System.Drawing.Point(402, 83);
            this.btn_Breach.Name = "btn_Breach";
            this.btn_Breach.Size = new System.Drawing.Size(75, 23);
            this.btn_Breach.TabIndex = 0;
            this.btn_Breach.Text = "Breach";
            this.btn_Breach.UseVisualStyleBackColor = true;
            this.btn_Breach.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_settemperature
            // 
            this.btn_settemperature.Location = new System.Drawing.Point(402, 323);
            this.btn_settemperature.Name = "btn_settemperature";
            this.btn_settemperature.Size = new System.Drawing.Size(75, 23);
            this.btn_settemperature.TabIndex = 17;
            this.btn_settemperature.Text = "Set";
            this.btn_settemperature.UseVisualStyleBackColor = true;
            this.btn_settemperature.Click += new System.EventHandler(this.btn_settemperature_Click);
            // 
            // txt_TemperatureSetter
            // 
            this.txt_TemperatureSetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TemperatureSetter.Location = new System.Drawing.Point(172, 323);
            this.txt_TemperatureSetter.Name = "txt_TemperatureSetter";
            this.txt_TemperatureSetter.Size = new System.Drawing.Size(224, 20);
            this.txt_TemperatureSetter.TabIndex = 10;
            // 
            // txt_OxygenSetter
            // 
            this.txt_OxygenSetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_OxygenSetter.Location = new System.Drawing.Point(172, 292);
            this.txt_OxygenSetter.Name = "txt_OxygenSetter";
            this.txt_OxygenSetter.Size = new System.Drawing.Size(224, 20);
            this.txt_OxygenSetter.TabIndex = 9;
            // 
            // txb_StatusSetter
            // 
            this.txb_StatusSetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_StatusSetter.Location = new System.Drawing.Point(172, 3);
            this.txb_StatusSetter.Name = "txb_StatusSetter";
            this.txb_StatusSetter.Size = new System.Drawing.Size(224, 20);
            this.txb_StatusSetter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Breach";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 129);
            this.label4.TabIndex = 2;
            this.label4.Text = "Heart Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Oxygen(Minutes)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Temperature";
            // 
            // lb_HeartRateSetter
            // 
            this.lb_HeartRateSetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_HeartRateSetter.FormattingEnabled = true;
            this.lb_HeartRateSetter.Items.AddRange(new object[] {
            "Green",
            "Yellow",
            "Red"});
            this.lb_HeartRateSetter.Location = new System.Drawing.Point(172, 163);
            this.lb_HeartRateSetter.Name = "lb_HeartRateSetter";
            this.lb_HeartRateSetter.Size = new System.Drawing.Size(224, 123);
            this.lb_HeartRateSetter.TabIndex = 11;
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(402, 3);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(75, 23);
            this.btn_Status.TabIndex = 13;
            this.btn_Status.Text = "Set";
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_heartRate
            // 
            this.btn_heartRate.Location = new System.Drawing.Point(402, 163);
            this.btn_heartRate.Name = "btn_heartRate";
            this.btn_heartRate.Size = new System.Drawing.Size(75, 23);
            this.btn_heartRate.TabIndex = 15;
            this.btn_heartRate.Text = "Set";
            this.btn_heartRate.UseVisualStyleBackColor = true;
            this.btn_heartRate.Click += new System.EventHandler(this.btn_heartRate_Click);
            // 
            // btn_AffectOxgyen
            // 
            this.btn_AffectOxgyen.Location = new System.Drawing.Point(402, 292);
            this.btn_AffectOxgyen.Name = "btn_AffectOxgyen";
            this.btn_AffectOxgyen.Size = new System.Drawing.Size(85, 23);
            this.btn_AffectOxgyen.TabIndex = 16;
            this.btn_AffectOxgyen.Text = "Add/Remove";
            this.btn_AffectOxgyen.UseVisualStyleBackColor = true;
            this.btn_AffectOxgyen.Click += new System.EventHandler(this.btn_AffectOxygen_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txt_Breach);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 74);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // txt_Breach
            // 
            this.txt_Breach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Breach.Location = new System.Drawing.Point(3, 3);
            this.txt_Breach.Name = "txt_Breach";
            this.txt_Breach.Size = new System.Drawing.Size(222, 20);
            this.txt_Breach.TabIndex = 10;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.tbc_Main);
            this.Name = "FRM_Main";
            this.Text = "Main";
            this.tbc_Main.ResumeLayout(false);
            this.tbp_Setup.ResumeLayout(false);
            this.tbp_Setup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbp_Status.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Main;
        private System.Windows.Forms.TabPage tbp_Setup;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TabPage tbp_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_NameLabel;
        private System.Windows.Forms.Label lb_StatusLabel;
        private System.Windows.Forms.Label lb_SuitPressureLabel;
        private System.Windows.Forms.Label lb_heartRateLabel;
        private System.Windows.Forms.Label lb_OxygenLabel;
        private System.Windows.Forms.TextBox txt_Temperature;
        private System.Windows.Forms.TextBox txt_Oxygen;
        private System.Windows.Forms.TextBox txt_Pressure;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lb_Temperature;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.ListBox lb_HeartRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_settemperature;
        private System.Windows.Forms.TextBox txt_TemperatureSetter;
        private System.Windows.Forms.TextBox txt_OxygenSetter;
        private System.Windows.Forms.TextBox txb_StatusSetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_HeartRateSetter;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_heartRate;
        private System.Windows.Forms.Button btn_AffectOxgyen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Breach;
        private System.Windows.Forms.RichTextBox errorBox;
        private System.Windows.Forms.TextBox txt_Breach;
    }
}

