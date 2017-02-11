namespace VotingSystemVer2.VotingForms
{
    partial class PrintResultsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrinterCmbBox = new System.Windows.Forms.ComboBox();
            this.PrinterLbl = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PrintChoiceGrpBox = new System.Windows.Forms.GroupBox();
            this.FileChkBox = new System.Windows.Forms.CheckBox();
            this.PrinterChkBox = new System.Windows.Forms.CheckBox();
            this.OnScreenChkBox = new System.Windows.Forms.CheckBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.PrintChoiceGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrinterCmbBox);
            this.panel1.Controls.Add(this.PrinterLbl);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // PrinterCmbBox
            // 
            this.PrinterCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrinterCmbBox.FormattingEnabled = true;
            this.PrinterCmbBox.Location = new System.Drawing.Point(6, 31);
            this.PrinterCmbBox.Name = "PrinterCmbBox";
            this.PrinterCmbBox.Size = new System.Drawing.Size(191, 21);
            this.PrinterCmbBox.TabIndex = 2;
            // 
            // PrinterLbl
            // 
            this.PrinterLbl.AutoSize = true;
            this.PrinterLbl.Location = new System.Drawing.Point(3, 15);
            this.PrinterLbl.Name = "PrinterLbl";
            this.PrinterLbl.Size = new System.Drawing.Size(43, 13);
            this.PrinterLbl.TabIndex = 1;
            this.PrinterLbl.Text = "Printer:";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(207, 170);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 23);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(288, 170);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // PrintChoiceGrpBox
            // 
            this.PrintChoiceGrpBox.Controls.Add(this.FileChkBox);
            this.PrintChoiceGrpBox.Controls.Add(this.PrinterChkBox);
            this.PrintChoiceGrpBox.Controls.Add(this.OnScreenChkBox);
            this.PrintChoiceGrpBox.Location = new System.Drawing.Point(218, 41);
            this.PrintChoiceGrpBox.Name = "PrintChoiceGrpBox";
            this.PrintChoiceGrpBox.Size = new System.Drawing.Size(145, 100);
            this.PrintChoiceGrpBox.TabIndex = 4;
            this.PrintChoiceGrpBox.TabStop = false;
            this.PrintChoiceGrpBox.Text = "Print Options";
            // 
            // FileChkBox
            // 
            this.FileChkBox.AutoSize = true;
            this.FileChkBox.Location = new System.Drawing.Point(6, 65);
            this.FileChkBox.Name = "FileChkBox";
            this.FileChkBox.Size = new System.Drawing.Size(80, 17);
            this.FileChkBox.TabIndex = 2;
            this.FileChkBox.Text = "Save to file";
            this.FileChkBox.UseVisualStyleBackColor = true;
            // 
            // PrinterChkBox
            // 
            this.PrinterChkBox.AutoSize = true;
            this.PrinterChkBox.Location = new System.Drawing.Point(6, 42);
            this.PrinterChkBox.Name = "PrinterChkBox";
            this.PrinterChkBox.Size = new System.Drawing.Size(98, 17);
            this.PrinterChkBox.TabIndex = 1;
            this.PrinterChkBox.Text = "Send to printer";
            this.PrinterChkBox.UseVisualStyleBackColor = true;
            // 
            // OnScreenChkBox
            // 
            this.OnScreenChkBox.AutoSize = true;
            this.OnScreenChkBox.Location = new System.Drawing.Point(6, 19);
            this.OnScreenChkBox.Name = "OnScreenChkBox";
            this.OnScreenChkBox.Size = new System.Drawing.Size(75, 17);
            this.OnScreenChkBox.TabIndex = 0;
            this.OnScreenChkBox.Text = "On screen";
            this.OnScreenChkBox.UseVisualStyleBackColor = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // PrintResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 205);
            this.Controls.Add(this.PrintChoiceGrpBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.panel1);
            this.Name = "PrintResultsForm";
            this.Text = "Print Results";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PrintChoiceGrpBox.ResumeLayout(false);
            this.PrintChoiceGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PrinterLbl;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox PrintChoiceGrpBox;
        private System.Windows.Forms.ComboBox PrinterCmbBox;
        private System.Windows.Forms.CheckBox FileChkBox;
        private System.Windows.Forms.CheckBox PrinterChkBox;
        private System.Windows.Forms.CheckBox OnScreenChkBox;
        private System.Drawing.Printing.PrintDocument printDocument;

    }
}