using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using VotingSystemVer2.CoreFunctions;
using System.IO;
using System.Drawing.Imaging;

namespace VotingSystemVer2.VotingForms
{
    public partial class ConfigureListForm : Form
    {
        List<Bitmap> icons = new List<Bitmap>();
        public ConfigureListForm()
        {
            InitializeComponent();
            checkBox1.Enabled = false;
            
        }

        private void ShowPnl_CheckedChanged(object sender, EventArgs e)
        {
            if(ChooseFromRbtn.Checked) 
            {
                YesNoPnl.Visible = false;
                ChooseFromPnl.Visible = true;
                checkBox1.Enabled = true;
                
                
            } else if (YesNoRBtn.Checked)
            {
                YesNoPnl.Visible = true;
                ChooseFromPnl.Visible = false;
                checkBox1.Enabled = false;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if(YesNoRBtn.Checked)
            {
                ChooseList.ChoiceList.Clear();
                ChooseList.question = QuestionTxt.Text;
                MemoryStream ms = new MemoryStream();
                new Bitmap("i:\\Symbols\\yes.png").Save(ms, ImageFormat.Bmp);
                byte[] bitmapData = ms.ToArray();
                ChooseList.ChoiceList.Add("Yes", bitmapData);
                ms = new MemoryStream();
                new Bitmap("i:\\Symbols\\no.png").Save(ms, ImageFormat.Bmp);
                bitmapData = ms.ToArray();
                ChooseList.ChoiceList.Add("No", bitmapData);
            }
            else if (ChooseFromRbtn.Checked)
            {
                ChooseList.ChoiceList.Clear();
                ChooseList.question = "Please select the desired choice that you want.";
                foreach(string item in ChoicesCmbBox.Items)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        icons[ChoicesCmbBox.FindStringExact(item)].Save(ms, ImageFormat.Bmp);
                        byte[] bitmapData = ms.ToArray();
                        ChooseList.ChoiceList.Add(item, bitmapData);
                    }
                    catch (Exception ex)
                    {
                        MemoryStream ms = new MemoryStream();
                        ((Bitmap)pictureBox1.Image).Save(ms, ImageFormat.Bmp);
                        byte[] bitmapData = ms.ToArray();
                        ChooseList.ChoiceList.Add(item, bitmapData);
                    }
                }
            }

            this.Close();
            this.Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ChoicesCmbBox.Items.Contains(ChoicesCmbBox.Text)) return;
            ChoicesCmbBox.Items.Add(ChoicesCmbBox.Text);
            icons.Add((Bitmap)pictureBox1.Image);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if(ChoicesCmbBox.Items.Count != 0)
            ChoicesCmbBox.Items.RemoveAt(ChoicesCmbBox.SelectedIndex);
        }

        private void ConfigureListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void symbolBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   string name = openFileDialog1.FileName;
                   Bitmap icon = new Bitmap(name);
                   ResizeNearestNeighbor resize = new ResizeNearestNeighbor(pictureBox1.Width, pictureBox1.Height);
                   pictureBox1.Image = resize.Apply(icon);
                   

                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ChooseList.multiChoice = true;
            }
            else
            {
                ChooseList.multiChoice = false;
            }
        }              
    }
}
