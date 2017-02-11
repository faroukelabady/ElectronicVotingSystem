using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;
namespace VotingSystemVer2.VotingForms
{
    public partial class PrintResultsForm : Form
    {
        DatabaseConnection.DataBase database;
        Dictionary<string, int> result;
        public PrintResultsForm()
        {
            InitializeComponent();
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {                
                PrinterCmbBox.Items.Add(PrinterSettings.InstalledPrinters[i]);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (OnScreenChkBox.Checked | PrinterChkBox.Checked | FileChkBox.Checked)
            {
                result = new Dictionary<string, int>();
                database = ((MainForm)Owner).Database;
                if (database == null)
                {
                    MessageBox.Show(this, "PLease connect to dataBase first", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //int i = database.countChoice("yes");
                //MessageBox.Show(i.ToString());

                //foreach (string text in CoreFunctions.ChooseList.ChoiceList)
                //{
                //    result.Add(text, database.countChoice(text));
                //}
            }

            if (OnScreenChkBox.Checked)
            {
                ResultForm result = new ResultForm(this.result);
                result.Show();
            }

            if (PrinterChkBox.Checked)
            {
                printDocument.PrinterSettings.PrinterName = PrinterCmbBox.SelectedItem.ToString();
                if (printDocument.PrinterSettings.IsValid)
                {
                    printDocument.Print();
                }
                else
                {
                    MessageBox.Show("Printer is invalid.");
                }                
            }

            if (FileChkBox.Checked)
            {
                StreamWriter file = new StreamWriter(Application.StartupPath +"\\Results.txt");
                file.WriteLine("Voting Results \n");
                file.WriteLine("Num \t Choice \t Result");
                int i = 1;
                foreach (KeyValuePair<string, int> choices in result)
                {

                    file.WriteLine("" + i + " \t " + choices.Key + " \t " + choices.Value);
                        
                    i++;
                }
                file.Close();
            }
            
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0;
            int count = 1;
            float topMargin = e.MarginBounds.Top;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            int i = database.countChoice("yes");
            Font printFont = new Font("Arial", 13, FontStyle.Bold | FontStyle.Underline);
            yPos = topMargin+10;

            e.Graphics.DrawString("Voting Results \n", printFont, Brushes.Black, (e.PageBounds.Width / 2) - 10,
                topMargin, format);

            printFont = new Font("Arial", 10 , FontStyle.Bold);
            yPos = topMargin + 30;
            float[] tabs = {100, 100};
            format.SetTabStops(0, tabs);

            e.Graphics.DrawString("Num \t Choice \t Result", printFont, Brushes.Black, (e.PageBounds.Width / 2) - 10,
                yPos, format);

            foreach (KeyValuePair<string, int> choices in result)
            {
                yPos += 30;
                format.SetTabStops(0, tabs);
                e.Graphics.DrawString("" + count +" \t " + choices.Key + " \t " + choices.Value,
                    printFont, Brushes.Black, (e.PageBounds.Width / 2) - 10,  yPos, format);
                count++;
            }
            
        }

        
        
    }
}
