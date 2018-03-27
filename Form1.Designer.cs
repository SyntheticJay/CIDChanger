namespace CIDChanger
{
    partial class MainForm
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
            this.groupConnection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.btnDisconnect = new MetroFramework.Controls.MetroButton();
            this.groupCID = new System.Windows.Forms.GroupBox();
            this.CIDBox = new MetroFramework.Controls.MetroTextBox();
            this.groupPSID = new System.Windows.Forms.GroupBox();
            this.PSIDBox = new MetroFramework.Controls.MetroTextBox();
            this.btnSetBoot = new MetroFramework.Controls.MetroButton();
            this.btnSetCID = new MetroFramework.Controls.MetroButton();
            this.btnSetPSID = new MetroFramework.Controls.MetroButton();
            this.groupConnection.SuspendLayout();
            this.groupCID.SuspendLayout();
            this.groupPSID.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupConnection
            // 
            this.groupConnection.Controls.Add(this.btnDisconnect);
            this.groupConnection.Controls.Add(this.btnConnect);
            this.groupConnection.Location = new System.Drawing.Point(23, 63);
            this.groupConnection.Name = "groupConnection";
            this.groupConnection.Size = new System.Drawing.Size(397, 88);
            this.groupConnection.TabIndex = 0;
            this.groupConnection.TabStop = false;
            this.groupConnection.Text = "Connection ";
            // 
            // btnConnect
            // 
            this.btnConnect.Highlight = false;
            this.btnConnect.Location = new System.Drawing.Point(22, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(142, 32);
            this.btnConnect.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnConnect.StyleManager = null;
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to PS3";
            this.btnConnect.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Highlight = false;
            this.btnDisconnect.Location = new System.Drawing.Point(227, 31);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(153, 32);
            this.btnDisconnect.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDisconnect.StyleManager = null;
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect from PS3";
            this.btnDisconnect.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupCID
            // 
            this.groupCID.Controls.Add(this.btnSetCID);
            this.groupCID.Controls.Add(this.btnSetBoot);
            this.groupCID.Controls.Add(this.CIDBox);
            this.groupCID.Location = new System.Drawing.Point(23, 175);
            this.groupCID.Name = "groupCID";
            this.groupCID.Size = new System.Drawing.Size(397, 112);
            this.groupCID.TabIndex = 1;
            this.groupCID.TabStop = false;
            this.groupCID.Text = "CID";
            // 
            // CIDBox
            // 
            this.CIDBox.CustomBackground = false;
            this.CIDBox.CustomForeColor = false;
            this.CIDBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.CIDBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.CIDBox.Location = new System.Drawing.Point(22, 33);
            this.CIDBox.Multiline = false;
            this.CIDBox.Name = "CIDBox";
            this.CIDBox.SelectedText = "";
            this.CIDBox.Size = new System.Drawing.Size(358, 23);
            this.CIDBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.CIDBox.StyleManager = null;
            this.CIDBox.TabIndex = 0;
            this.CIDBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CIDBox.UseStyleColors = false;
            // 
            // groupPSID
            // 
            this.groupPSID.Controls.Add(this.btnSetPSID);
            this.groupPSID.Controls.Add(this.PSIDBox);
            this.groupPSID.Location = new System.Drawing.Point(23, 304);
            this.groupPSID.Name = "groupPSID";
            this.groupPSID.Size = new System.Drawing.Size(397, 112);
            this.groupPSID.TabIndex = 2;
            this.groupPSID.TabStop = false;
            this.groupPSID.Text = "PSID";
            // 
            // PSIDBox
            // 
            this.PSIDBox.CustomBackground = false;
            this.PSIDBox.CustomForeColor = false;
            this.PSIDBox.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.PSIDBox.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.PSIDBox.Location = new System.Drawing.Point(22, 33);
            this.PSIDBox.Multiline = false;
            this.PSIDBox.Name = "PSIDBox";
            this.PSIDBox.SelectedText = "";
            this.PSIDBox.Size = new System.Drawing.Size(358, 23);
            this.PSIDBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PSIDBox.StyleManager = null;
            this.PSIDBox.TabIndex = 0;
            this.PSIDBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PSIDBox.UseStyleColors = false;
            // 
            // btnSetBoot
            // 
            this.btnSetBoot.Highlight = false;
            this.btnSetBoot.Location = new System.Drawing.Point(22, 62);
            this.btnSetBoot.Name = "btnSetBoot";
            this.btnSetBoot.Size = new System.Drawing.Size(153, 32);
            this.btnSetBoot.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSetBoot.StyleManager = null;
            this.btnSetBoot.TabIndex = 2;
            this.btnSetBoot.Text = "Set Boot CID";
            this.btnSetBoot.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSetBoot.Click += new System.EventHandler(this.btnSetBoot_Click);
            // 
            // btnSetCID
            // 
            this.btnSetCID.Highlight = false;
            this.btnSetCID.Location = new System.Drawing.Point(227, 62);
            this.btnSetCID.Name = "btnSetCID";
            this.btnSetCID.Size = new System.Drawing.Size(153, 32);
            this.btnSetCID.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSetCID.StyleManager = null;
            this.btnSetCID.TabIndex = 3;
            this.btnSetCID.Text = "Set Current CID";
            this.btnSetCID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSetCID.Click += new System.EventHandler(this.btnSetCID_Click);
            // 
            // btnSetPSID
            // 
            this.btnSetPSID.Highlight = false;
            this.btnSetPSID.Location = new System.Drawing.Point(122, 62);
            this.btnSetPSID.Name = "btnSetPSID";
            this.btnSetPSID.Size = new System.Drawing.Size(153, 32);
            this.btnSetPSID.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSetPSID.StyleManager = null;
            this.btnSetPSID.TabIndex = 4;
            this.btnSetPSID.Text = "PSID";
            this.btnSetPSID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSetPSID.Click += new System.EventHandler(this.btnSetPSID_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 434);
            this.Controls.Add(this.groupPSID);
            this.Controls.Add(this.groupCID);
            this.Controls.Add(this.groupConnection);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainForm";
            this.Text = "CID Changer | By Reduction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupConnection.ResumeLayout(false);
            this.groupCID.ResumeLayout(false);
            this.groupPSID.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConnection;
        private MetroFramework.Controls.MetroButton btnDisconnect;
        private MetroFramework.Controls.MetroButton btnConnect;
        private System.Windows.Forms.GroupBox groupCID;
        private MetroFramework.Controls.MetroButton btnSetCID;
        private MetroFramework.Controls.MetroButton btnSetBoot;
        private MetroFramework.Controls.MetroTextBox CIDBox;
        private System.Windows.Forms.GroupBox groupPSID;
        private MetroFramework.Controls.MetroButton btnSetPSID;
        private MetroFramework.Controls.MetroTextBox PSIDBox;
    }
}

