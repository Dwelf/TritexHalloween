namespace TritexHalloween.StoryController
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
            this.tabC_Main = new System.Windows.Forms.TabControl();
            this.tbp_Adventurer = new System.Windows.Forms.TabPage();
            this.tbp_AudioLogs = new System.Windows.Forms.TabPage();
            this.tbp_Setup = new System.Windows.Forms.TabPage();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tabC_Main.SuspendLayout();
            this.tbp_Setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabC_Main
            // 
            this.tabC_Main.Controls.Add(this.tbp_Setup);
            this.tabC_Main.Controls.Add(this.tbp_Adventurer);
            this.tabC_Main.Controls.Add(this.tbp_AudioLogs);
            this.tabC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabC_Main.Location = new System.Drawing.Point(0, 0);
            this.tabC_Main.Name = "tabC_Main";
            this.tabC_Main.SelectedIndex = 0;
            this.tabC_Main.Size = new System.Drawing.Size(800, 450);
            this.tabC_Main.TabIndex = 0;
            // 
            // tbp_Adventurer
            // 
            this.tbp_Adventurer.Location = new System.Drawing.Point(4, 22);
            this.tbp_Adventurer.Name = "tbp_Adventurer";
            this.tbp_Adventurer.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Adventurer.Size = new System.Drawing.Size(792, 424);
            this.tbp_Adventurer.TabIndex = 0;
            this.tbp_Adventurer.Text = "Adventurer";
            this.tbp_Adventurer.UseVisualStyleBackColor = true;
            // 
            // tbp_AudioLogs
            // 
            this.tbp_AudioLogs.Location = new System.Drawing.Point(4, 22);
            this.tbp_AudioLogs.Name = "tbp_AudioLogs";
            this.tbp_AudioLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_AudioLogs.Size = new System.Drawing.Size(792, 424);
            this.tbp_AudioLogs.TabIndex = 1;
            this.tbp_AudioLogs.Text = "Audio Logs";
            this.tbp_AudioLogs.UseVisualStyleBackColor = true;
            // 
            // tbp_Setup
            // 
            this.tbp_Setup.Controls.Add(this.btn_Connect);
            this.tbp_Setup.Controls.Add(this.txt_IPAddress);
            this.tbp_Setup.Location = new System.Drawing.Point(4, 22);
            this.tbp_Setup.Name = "tbp_Setup";
            this.tbp_Setup.Size = new System.Drawing.Size(792, 424);
            this.tbp_Setup.TabIndex = 2;
            this.tbp_Setup.Text = "Setup";
            this.tbp_Setup.UseVisualStyleBackColor = true;
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(0, 0);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(172, 20);
            this.txt_IPAddress.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(178, -3);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabC_Main);
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabC_Main.ResumeLayout(false);
            this.tbp_Setup.ResumeLayout(false);
            this.tbp_Setup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_Main;
        private System.Windows.Forms.TabPage tbp_Adventurer;
        private System.Windows.Forms.TabPage tbp_AudioLogs;
        private System.Windows.Forms.TabPage tbp_Setup;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_IPAddress;
    }
}