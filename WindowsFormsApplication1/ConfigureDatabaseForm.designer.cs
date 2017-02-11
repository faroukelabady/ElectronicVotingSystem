namespace VotingSystemVer2.VotingForms
{
    partial class ConfigureDatabaseForm
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
            this.DataBasePnl = new System.Windows.Forms.Panel();
            this.DBTabCtrl = new System.Windows.Forms.TabControl();
            this.LocatTab = new System.Windows.Forms.TabPage();
            this.HostTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassLocalTxt = new System.Windows.Forms.TextBox();
            this.UserLocalTxt = new System.Windows.Forms.TextBox();
            this.LocalDBLbl = new System.Windows.Forms.Label();
            this.RemoteTab = new System.Windows.Forms.TabPage();
            this.PassLbl = new System.Windows.Forms.Label();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PortLbl = new System.Windows.Forms.Label();
            this.IPLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.IPTxt = new System.Windows.Forms.TextBox();
            this.ConnectDBBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateDBBtn = new System.Windows.Forms.Button();
            this.ClearTableBtn = new System.Windows.Forms.Button();
            this.DataBasePnl.SuspendLayout();
            this.DBTabCtrl.SuspendLayout();
            this.LocatTab.SuspendLayout();
            this.RemoteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataBasePnl
            // 
            this.DataBasePnl.Controls.Add(this.DBTabCtrl);
            this.DataBasePnl.Location = new System.Drawing.Point(12, 12);
            this.DataBasePnl.Name = "DataBasePnl";
            this.DataBasePnl.Size = new System.Drawing.Size(291, 168);
            this.DataBasePnl.TabIndex = 0;
            // 
            // DBTabCtrl
            // 
            this.DBTabCtrl.Controls.Add(this.LocatTab);
            this.DBTabCtrl.Controls.Add(this.RemoteTab);
            this.DBTabCtrl.Location = new System.Drawing.Point(3, 3);
            this.DBTabCtrl.Name = "DBTabCtrl";
            this.DBTabCtrl.SelectedIndex = 0;
            this.DBTabCtrl.Size = new System.Drawing.Size(279, 162);
            this.DBTabCtrl.TabIndex = 0;
            // 
            // LocatTab
            // 
            this.LocatTab.Controls.Add(this.HostTxt);
            this.LocatTab.Controls.Add(this.label1);
            this.LocatTab.Controls.Add(this.label2);
            this.LocatTab.Controls.Add(this.PassLocalTxt);
            this.LocatTab.Controls.Add(this.UserLocalTxt);
            this.LocatTab.Controls.Add(this.LocalDBLbl);
            this.LocatTab.Location = new System.Drawing.Point(4, 22);
            this.LocatTab.Name = "LocatTab";
            this.LocatTab.Padding = new System.Windows.Forms.Padding(3);
            this.LocatTab.Size = new System.Drawing.Size(271, 136);
            this.LocatTab.TabIndex = 0;
            this.LocatTab.Text = "Local DataBase";
            this.LocatTab.UseVisualStyleBackColor = true;
            // 
            // HostTxt
            // 
            this.HostTxt.Location = new System.Drawing.Point(60, 24);
            this.HostTxt.Name = "HostTxt";
            this.HostTxt.Size = new System.Drawing.Size(205, 20);
            this.HostTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pass:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "User:";
            // 
            // PassLocalTxt
            // 
            this.PassLocalTxt.Location = new System.Drawing.Point(60, 93);
            this.PassLocalTxt.Name = "PassLocalTxt";
            this.PassLocalTxt.Size = new System.Drawing.Size(208, 20);
            this.PassLocalTxt.TabIndex = 9;
            this.PassLocalTxt.UseSystemPasswordChar = true;
            // 
            // UserLocalTxt
            // 
            this.UserLocalTxt.Location = new System.Drawing.Point(60, 60);
            this.UserLocalTxt.Name = "UserLocalTxt";
            this.UserLocalTxt.Size = new System.Drawing.Size(205, 20);
            this.UserLocalTxt.TabIndex = 8;
            // 
            // LocalDBLbl
            // 
            this.LocalDBLbl.AutoSize = true;
            this.LocalDBLbl.Location = new System.Drawing.Point(-3, 32);
            this.LocalDBLbl.Name = "LocalDBLbl";
            this.LocalDBLbl.Size = new System.Drawing.Size(57, 13);
            this.LocalDBLbl.TabIndex = 1;
            this.LocalDBLbl.Text = "DataBase:";
            // 
            // RemoteTab
            // 
            this.RemoteTab.Controls.Add(this.PassLbl);
            this.RemoteTab.Controls.Add(this.UserLbl);
            this.RemoteTab.Controls.Add(this.PortLbl);
            this.RemoteTab.Controls.Add(this.IPLbl);
            this.RemoteTab.Controls.Add(this.PasswordTxt);
            this.RemoteTab.Controls.Add(this.UserTxt);
            this.RemoteTab.Controls.Add(this.PortTxt);
            this.RemoteTab.Controls.Add(this.IPTxt);
            this.RemoteTab.Location = new System.Drawing.Point(4, 22);
            this.RemoteTab.Name = "RemoteTab";
            this.RemoteTab.Padding = new System.Windows.Forms.Padding(3);
            this.RemoteTab.Size = new System.Drawing.Size(271, 136);
            this.RemoteTab.TabIndex = 1;
            this.RemoteTab.Text = "Remote DataBase";
            this.RemoteTab.UseVisualStyleBackColor = true;
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(10, 99);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(33, 13);
            this.PassLbl.TabIndex = 7;
            this.PassLbl.Text = "Pass:";
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(10, 73);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(33, 13);
            this.UserLbl.TabIndex = 6;
            this.UserLbl.Text = "User:";
            // 
            // PortLbl
            // 
            this.PortLbl.AutoSize = true;
            this.PortLbl.Location = new System.Drawing.Point(10, 47);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(31, 13);
            this.PortLbl.TabIndex = 5;
            this.PortLbl.Text = "Port:";
            // 
            // IPLbl
            // 
            this.IPLbl.AutoSize = true;
            this.IPLbl.Location = new System.Drawing.Point(10, 21);
            this.IPLbl.Name = "IPLbl";
            this.IPLbl.Size = new System.Drawing.Size(21, 13);
            this.IPLbl.TabIndex = 4;
            this.IPLbl.Text = "IP:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(49, 96);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(169, 20);
            this.PasswordTxt.TabIndex = 3;
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(49, 70);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(169, 20);
            this.UserTxt.TabIndex = 2;
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(49, 44);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(169, 20);
            this.PortTxt.TabIndex = 1;
            // 
            // IPTxt
            // 
            this.IPTxt.Location = new System.Drawing.Point(49, 18);
            this.IPTxt.Name = "IPTxt";
            this.IPTxt.Size = new System.Drawing.Size(169, 20);
            this.IPTxt.TabIndex = 0;
            // 
            // ConnectDBBtn
            // 
            this.ConnectDBBtn.Location = new System.Drawing.Point(233, 196);
            this.ConnectDBBtn.Name = "ConnectDBBtn";
            this.ConnectDBBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectDBBtn.TabIndex = 1;
            this.ConnectDBBtn.Text = "Connect";
            this.ConnectDBBtn.UseVisualStyleBackColor = true;
            this.ConnectDBBtn.Click += new System.EventHandler(this.ConnectDBBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(233, 225);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateDBBtn
            // 
            this.CreateDBBtn.Location = new System.Drawing.Point(12, 196);
            this.CreateDBBtn.Name = "CreateDBBtn";
            this.CreateDBBtn.Size = new System.Drawing.Size(118, 23);
            this.CreateDBBtn.TabIndex = 3;
            this.CreateDBBtn.Text = "Create DataBase";
            this.CreateDBBtn.UseVisualStyleBackColor = true;
            this.CreateDBBtn.Click += new System.EventHandler(this.CreateDBBtn_Click);
            // 
            // ClearTableBtn
            // 
            this.ClearTableBtn.Location = new System.Drawing.Point(12, 225);
            this.ClearTableBtn.Name = "ClearTableBtn";
            this.ClearTableBtn.Size = new System.Drawing.Size(118, 23);
            this.ClearTableBtn.TabIndex = 4;
            this.ClearTableBtn.Text = "Clear Pervious data";
            this.ClearTableBtn.UseVisualStyleBackColor = true;
            this.ClearTableBtn.Click += new System.EventHandler(this.ClearTableBtn_Click);
            // 
            // ConfigureDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 259);
            this.Controls.Add(this.ClearTableBtn);
            this.Controls.Add(this.CreateDBBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConnectDBBtn);
            this.Controls.Add(this.DataBasePnl);
            this.Name = "ConfigureDatabaseForm";
            this.Text = "Configure Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureDatabaseForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigureDatabaseForm_Load);
            this.DataBasePnl.ResumeLayout(false);
            this.DBTabCtrl.ResumeLayout(false);
            this.LocatTab.ResumeLayout(false);
            this.LocatTab.PerformLayout();
            this.RemoteTab.ResumeLayout(false);
            this.RemoteTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataBasePnl;
        private System.Windows.Forms.TabControl DBTabCtrl;
        private System.Windows.Forms.TabPage LocatTab;
        private System.Windows.Forms.Label LocalDBLbl;
        private System.Windows.Forms.TabPage RemoteTab;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label PortLbl;
        private System.Windows.Forms.Label IPLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.TextBox IPTxt;
        private System.Windows.Forms.Button ConnectDBBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassLocalTxt;
        private System.Windows.Forms.TextBox UserLocalTxt;
        private System.Windows.Forms.TextBox HostTxt;
        private System.Windows.Forms.Button CreateDBBtn;
        private System.Windows.Forms.Button ClearTableBtn;
    }
}