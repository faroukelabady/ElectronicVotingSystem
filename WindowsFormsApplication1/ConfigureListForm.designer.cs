namespace VotingSystemVer2.VotingForms
{
    partial class ConfigureListForm
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
            this.ChooseListGrpBox = new System.Windows.Forms.GroupBox();
            this.ChooseFromRbtn = new System.Windows.Forms.RadioButton();
            this.YesNoRBtn = new System.Windows.Forms.RadioButton();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.YesNoPnl = new System.Windows.Forms.Panel();
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.QuestionTxt = new System.Windows.Forms.TextBox();
            this.ChooseFromPnl = new System.Windows.Forms.Panel();
            this.ChoicesCmbBox = new System.Windows.Forms.ComboBox();
            this.ChoicesLbl = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.symbolBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ChooseListGrpBox.SuspendLayout();
            this.YesNoPnl.SuspendLayout();
            this.ChooseFromPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseListGrpBox
            // 
            this.ChooseListGrpBox.Controls.Add(this.checkBox1);
            this.ChooseListGrpBox.Controls.Add(this.ChooseFromRbtn);
            this.ChooseListGrpBox.Controls.Add(this.YesNoRBtn);
            this.ChooseListGrpBox.Location = new System.Drawing.Point(12, 29);
            this.ChooseListGrpBox.Name = "ChooseListGrpBox";
            this.ChooseListGrpBox.Size = new System.Drawing.Size(200, 115);
            this.ChooseListGrpBox.TabIndex = 0;
            this.ChooseListGrpBox.TabStop = false;
            this.ChooseListGrpBox.Text = "Choose List Type";
            // 
            // ChooseFromRbtn
            // 
            this.ChooseFromRbtn.AutoSize = true;
            this.ChooseFromRbtn.Location = new System.Drawing.Point(19, 61);
            this.ChooseFromRbtn.Name = "ChooseFromRbtn";
            this.ChooseFromRbtn.Size = new System.Drawing.Size(107, 17);
            this.ChooseFromRbtn.TabIndex = 1;
            this.ChooseFromRbtn.Text = "Choose From List";
            this.ChooseFromRbtn.UseVisualStyleBackColor = true;
            this.ChooseFromRbtn.CheckedChanged += new System.EventHandler(this.ShowPnl_CheckedChanged);
            // 
            // YesNoRBtn
            // 
            this.YesNoRBtn.AutoSize = true;
            this.YesNoRBtn.Checked = true;
            this.YesNoRBtn.Location = new System.Drawing.Point(19, 38);
            this.YesNoRBtn.Name = "YesNoRBtn";
            this.YesNoRBtn.Size = new System.Drawing.Size(81, 17);
            this.YesNoRBtn.TabIndex = 0;
            this.YesNoRBtn.TabStop = true;
            this.YesNoRBtn.Text = "Yes, No List";
            this.YesNoRBtn.UseVisualStyleBackColor = true;
            this.YesNoRBtn.CheckedChanged += new System.EventHandler(this.ShowPnl_CheckedChanged);
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(228, 214);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(334, 214);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // YesNoPnl
            // 
            this.YesNoPnl.Controls.Add(this.QuestionLbl);
            this.YesNoPnl.Controls.Add(this.QuestionTxt);
            this.YesNoPnl.Location = new System.Drawing.Point(225, 29);
            this.YesNoPnl.Name = "YesNoPnl";
            this.YesNoPnl.Size = new System.Drawing.Size(200, 100);
            this.YesNoPnl.TabIndex = 3;
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Location = new System.Drawing.Point(4, 4);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(54, 13);
            this.QuestionLbl.TabIndex = 1;
            this.QuestionLbl.Text = "Question:";
            // 
            // QuestionTxt
            // 
            this.QuestionTxt.Location = new System.Drawing.Point(7, 20);
            this.QuestionTxt.Multiline = true;
            this.QuestionTxt.Name = "QuestionTxt";
            this.QuestionTxt.Size = new System.Drawing.Size(190, 77);
            this.QuestionTxt.TabIndex = 0;
            // 
            // ChooseFromPnl
            // 
            this.ChooseFromPnl.Controls.Add(this.symbolBtn);
            this.ChooseFromPnl.Controls.Add(this.pictureBox1);
            this.ChooseFromPnl.Controls.Add(this.ChoicesCmbBox);
            this.ChooseFromPnl.Controls.Add(this.ChoicesLbl);
            this.ChooseFromPnl.Controls.Add(this.RemoveBtn);
            this.ChooseFromPnl.Controls.Add(this.AddBtn);
            this.ChooseFromPnl.Location = new System.Drawing.Point(225, 29);
            this.ChooseFromPnl.Name = "ChooseFromPnl";
            this.ChooseFromPnl.Size = new System.Drawing.Size(200, 156);
            this.ChooseFromPnl.TabIndex = 4;
            this.ChooseFromPnl.Visible = false;
            // 
            // ChoicesCmbBox
            // 
            this.ChoicesCmbBox.FormattingEnabled = true;
            this.ChoicesCmbBox.Location = new System.Drawing.Point(3, 20);
            this.ChoicesCmbBox.Name = "ChoicesCmbBox";
            this.ChoicesCmbBox.Size = new System.Drawing.Size(181, 21);
            this.ChoicesCmbBox.TabIndex = 7;
            // 
            // ChoicesLbl
            // 
            this.ChoicesLbl.AutoSize = true;
            this.ChoicesLbl.Location = new System.Drawing.Point(6, 4);
            this.ChoicesLbl.Name = "ChoicesLbl";
            this.ChoicesLbl.Size = new System.Drawing.Size(48, 13);
            this.ChoicesLbl.TabIndex = 6;
            this.ChoicesLbl.Text = "Choices:";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(109, 43);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(3, 43);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(9, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // symbolBtn
            // 
            this.symbolBtn.Location = new System.Drawing.Point(109, 119);
            this.symbolBtn.Name = "symbolBtn";
            this.symbolBtn.Size = new System.Drawing.Size(88, 23);
            this.symbolBtn.TabIndex = 9;
            this.symbolBtn.Text = "Add Symbol";
            this.symbolBtn.UseVisualStyleBackColor = true;
            this.symbolBtn.Click += new System.EventHandler(this.symbolBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Multi choice";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ConfigureListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 251);
            this.Controls.Add(this.ChooseFromPnl);
            this.Controls.Add(this.YesNoPnl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ChooseListGrpBox);
            this.Name = "ConfigureListForm";
            this.Text = "Configure Choose List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureListForm_FormClosing);
            this.ChooseListGrpBox.ResumeLayout(false);
            this.ChooseListGrpBox.PerformLayout();
            this.YesNoPnl.ResumeLayout(false);
            this.YesNoPnl.PerformLayout();
            this.ChooseFromPnl.ResumeLayout(false);
            this.ChooseFromPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ChooseListGrpBox;
        private System.Windows.Forms.RadioButton ChooseFromRbtn;
        private System.Windows.Forms.RadioButton YesNoRBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel YesNoPnl;
        private System.Windows.Forms.Label QuestionLbl;
        private System.Windows.Forms.TextBox QuestionTxt;
        private System.Windows.Forms.Panel ChooseFromPnl;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label ChoicesLbl;
        private System.Windows.Forms.ComboBox ChoicesCmbBox;
        private System.Windows.Forms.Button symbolBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}