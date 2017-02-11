namespace VotingSystemVer2.VotingForms
{
    partial class ChangeRGBForm
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
            this.RedTrkBar = new System.Windows.Forms.TrackBar();
            this.GreenTrkBar = new System.Windows.Forms.TrackBar();
            this.BlueTrkBar = new System.Windows.Forms.TrackBar();
            this.RedLbl = new System.Windows.Forms.Label();
            this.GreenLbl = new System.Windows.Forms.Label();
            this.BlueLbl = new System.Windows.Forms.Label();
            this.IDPicBox = new System.Windows.Forms.PictureBox();
            this.RedValueTxt = new System.Windows.Forms.TextBox();
            this.GreenValueTxt = new System.Windows.Forms.TextBox();
            this.BlueValueTxt = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrkBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrkBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrkBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RedTrkBar
            // 
            this.RedTrkBar.Location = new System.Drawing.Point(75, 26);
            this.RedTrkBar.Maximum = 255;
            this.RedTrkBar.Name = "RedTrkBar";
            this.RedTrkBar.Size = new System.Drawing.Size(376, 45);
            this.RedTrkBar.TabIndex = 0;
            this.RedTrkBar.Scroll += new System.EventHandler(this.RedTrkBar_Scroll);
            // 
            // GreenTrkBar
            // 
            this.GreenTrkBar.Location = new System.Drawing.Point(75, 77);
            this.GreenTrkBar.Maximum = 255;
            this.GreenTrkBar.Name = "GreenTrkBar";
            this.GreenTrkBar.Size = new System.Drawing.Size(376, 45);
            this.GreenTrkBar.TabIndex = 1;
            this.GreenTrkBar.Scroll += new System.EventHandler(this.GreenTrkBar_Scroll);
            // 
            // BlueTrkBar
            // 
            this.BlueTrkBar.Location = new System.Drawing.Point(75, 128);
            this.BlueTrkBar.Maximum = 255;
            this.BlueTrkBar.Name = "BlueTrkBar";
            this.BlueTrkBar.Size = new System.Drawing.Size(376, 45);
            this.BlueTrkBar.TabIndex = 2;
            this.BlueTrkBar.Scroll += new System.EventHandler(this.BlueTrkBar_Scroll);
            // 
            // RedLbl
            // 
            this.RedLbl.AutoSize = true;
            this.RedLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.RedLbl.Location = new System.Drawing.Point(12, 26);
            this.RedLbl.Name = "RedLbl";
            this.RedLbl.Size = new System.Drawing.Size(46, 22);
            this.RedLbl.TabIndex = 3;
            this.RedLbl.Text = "Red:";
            // 
            // GreenLbl
            // 
            this.GreenLbl.AutoSize = true;
            this.GreenLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.GreenLbl.Location = new System.Drawing.Point(12, 77);
            this.GreenLbl.Name = "GreenLbl";
            this.GreenLbl.Size = new System.Drawing.Size(62, 22);
            this.GreenLbl.TabIndex = 4;
            this.GreenLbl.Text = "Green:";
            // 
            // BlueLbl
            // 
            this.BlueLbl.AutoSize = true;
            this.BlueLbl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BlueLbl.Location = new System.Drawing.Point(12, 128);
            this.BlueLbl.Name = "BlueLbl";
            this.BlueLbl.Size = new System.Drawing.Size(50, 22);
            this.BlueLbl.TabIndex = 5;
            this.BlueLbl.Text = "Blue:";
            // 
            // IDPicBox
            // 
            this.IDPicBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IDPicBox.Location = new System.Drawing.Point(97, 179);
            this.IDPicBox.Name = "IDPicBox";
            this.IDPicBox.Size = new System.Drawing.Size(323, 65);
            this.IDPicBox.TabIndex = 6;
            this.IDPicBox.TabStop = false;
            // 
            // RedValueTxt
            // 
            this.RedValueTxt.Location = new System.Drawing.Point(457, 29);
            this.RedValueTxt.Name = "RedValueTxt";
            this.RedValueTxt.Size = new System.Drawing.Size(52, 20);
            this.RedValueTxt.TabIndex = 7;
            // 
            // GreenValueTxt
            // 
            this.GreenValueTxt.Location = new System.Drawing.Point(457, 80);
            this.GreenValueTxt.Name = "GreenValueTxt";
            this.GreenValueTxt.Size = new System.Drawing.Size(52, 20);
            this.GreenValueTxt.TabIndex = 8;
            // 
            // BlueValueTxt
            // 
            this.BlueValueTxt.Location = new System.Drawing.Point(457, 128);
            this.BlueValueTxt.Name = "BlueValueTxt";
            this.BlueValueTxt.Size = new System.Drawing.Size(52, 20);
            this.BlueValueTxt.TabIndex = 9;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(345, 250);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 10;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(434, 250);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ChangeRGBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 285);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.BlueValueTxt);
            this.Controls.Add(this.GreenValueTxt);
            this.Controls.Add(this.RedValueTxt);
            this.Controls.Add(this.IDPicBox);
            this.Controls.Add(this.BlueLbl);
            this.Controls.Add(this.GreenLbl);
            this.Controls.Add(this.RedLbl);
            this.Controls.Add(this.BlueTrkBar);
            this.Controls.Add(this.GreenTrkBar);
            this.Controls.Add(this.RedTrkBar);
            this.Name = "ChangeRGBForm";
            this.Text = "ChangeRGBForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeRGBForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RedTrkBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrkBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrkBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RedTrkBar;
        private System.Windows.Forms.TrackBar GreenTrkBar;
        private System.Windows.Forms.TrackBar BlueTrkBar;
        private System.Windows.Forms.Label RedLbl;
        private System.Windows.Forms.Label GreenLbl;
        private System.Windows.Forms.Label BlueLbl;
        private System.Windows.Forms.PictureBox IDPicBox;
        private System.Windows.Forms.TextBox RedValueTxt;
        private System.Windows.Forms.TextBox GreenValueTxt;
        private System.Windows.Forms.TextBox BlueValueTxt;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}