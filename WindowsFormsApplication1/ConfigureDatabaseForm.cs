using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VotingSystemVer2.DatabaseConnection;
namespace VotingSystemVer2.VotingForms
{
    public partial class ConfigureDatabaseForm : Form
    {
        static DataBase database = null;

        public static DataBase Database
        {
            get { return ConfigureDatabaseForm.database; }
            set { ConfigureDatabaseForm.database = value; }
        }

        public ConfigureDatabaseForm()
        {
            InitializeComponent();
        }

        private void ConfigureDatabaseForm_Load(object sender, EventArgs e)
        {               
            
        }

        private void ConnectDBBtn_Click(object sender, EventArgs e)
        {
            if (DBTabCtrl.SelectedTab == DBTabCtrl.TabPages[0])
            {
                if (HostTxt.Text == "" | UserLocalTxt.Text == "" | PassLocalTxt.Text == "")
                {
                    MessageBox.Show(this, "Please insert Database Information.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                database = new LocalDatabase(HostTxt.Text, UserLocalTxt.Text, PassLocalTxt.Text);
                ((MainForm)Owner).Database = database;
                
                if (!database.connect())                
                    MessageBox.Show(this, "Cannot connect to database", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                               
            }
        }

        private void CreateDBBtn_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                if (database.createDB())                
                    MessageBox.Show(this, "DataBase Created.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Database already created or cannot be created.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void ClearTableBtn_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to clear all data.", "Warning",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (database.clearData())
                        MessageBox.Show(this, "Data Cleared.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data Cannot be Cleared.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ConfigureDatabaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
