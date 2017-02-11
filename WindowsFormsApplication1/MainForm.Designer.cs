namespace VotingSystemVer2.VotingForms
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
            this.components = new System.ComponentModel.Container();
            this.imagesTxt = new System.Windows.Forms.TextBox();
            this.imagesLocLbl = new System.Windows.Forms.Label();
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagesTxt
            // 
            this.imagesTxt.Location = new System.Drawing.Point(12, 53);
            this.imagesTxt.Name = "imagesTxt";
            this.imagesTxt.Size = new System.Drawing.Size(194, 20);
            this.imagesTxt.TabIndex = 0;
            // 
            // imagesLocLbl
            // 
            this.imagesLocLbl.AutoSize = true;
            this.imagesLocLbl.Location = new System.Drawing.Point(12, 37);
            this.imagesLocLbl.Name = "imagesLocLbl";
            this.imagesLocLbl.Size = new System.Drawing.Size(88, 13);
            this.imagesLocLbl.TabIndex = 1;
            this.imagesLocLbl.Text = "Images Loctions:";
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.Location = new System.Drawing.Point(177, 227);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(95, 23);
            this.StartServerBtn.TabIndex = 2;
            this.StartServerBtn.Text = "Start Server";
            this.StartServerBtn.UseVisualStyleBackColor = true;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "*.jpg";
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseDatabaseToolStripMenuItem,
            this.chooseListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // chooseDatabaseToolStripMenuItem
            // 
            this.chooseDatabaseToolStripMenuItem.Name = "chooseDatabaseToolStripMenuItem";
            this.chooseDatabaseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.chooseDatabaseToolStripMenuItem.Text = "Choose Database";
            this.chooseDatabaseToolStripMenuItem.Click += new System.EventHandler(this.chooseDatabaseToolStripMenuItem_Click);
            // 
            // chooseListToolStripMenuItem
            // 
            this.chooseListToolStripMenuItem.Name = "chooseListToolStripMenuItem";
            this.chooseListToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.chooseListToolStripMenuItem.Text = "Choose List";
            this.chooseListToolStripMenuItem.Click += new System.EventHandler(this.chooseListToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNGToolStripMenuItem,
            this.arabicToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // eNGToolStripMenuItem
            // 
            this.eNGToolStripMenuItem.Name = "eNGToolStripMenuItem";
            this.eNGToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.eNGToolStripMenuItem.Text = "Arabic";
            // 
            // arabicToolStripMenuItem
            // 
            this.arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            this.arabicToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.arabicToolStripMenuItem.Text = "English";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.StartServerBtn);
            this.Controls.Add(this.imagesLocLbl);
            this.Controls.Add(this.imagesTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagesTxt;
        private System.Windows.Forms.Label imagesLocLbl;
        private System.Windows.Forms.Button StartServerBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

