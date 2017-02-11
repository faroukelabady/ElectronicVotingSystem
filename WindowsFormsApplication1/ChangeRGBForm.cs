using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VotingSystemVer2.CoreFunctions;

namespace VotingSystemVer2.VotingForms
{
    public partial class ChangeRGBForm : Form
    {
        Bitmap image;
        NumExtraction ne;
        public ChangeRGBForm()
        {
            InitializeComponent();
        }
        public ChangeRGBForm(Bitmap image)
        {
            InitializeComponent();
            this.image = image;
            this.ne = new NumExtraction(image);
            RedTrkBar.Value = ne.RedVal;
            GreenTrkBar.Value = ne.GreenVal;
            BlueTrkBar.Value = ne.BlueVal;
            RedValueTxt.Text = RedTrkBar.Value.ToString();
            GreenValueTxt.Text = GreenTrkBar.Value.ToString();
            BlueValueTxt.Text = BlueTrkBar.Value.ToString();
            IDPicBox.Image = ne.Img2BW(image);
        }

        private void RedTrkBar_Scroll(object sender, EventArgs e)
        {
            RedValueTxt.Text = RedTrkBar.Value.ToString();
            ne.RedVal = RedTrkBar.Value;
            IDPicBox.Image = ne.Img2BW(image);
        }

        private void GreenTrkBar_Scroll(object sender, EventArgs e)
        {
            GreenValueTxt.Text = GreenTrkBar.Value.ToString();
            ne.GreenVal = GreenTrkBar.Value;
            IDPicBox.Image = ne.Img2BW(image);
        }

        private void BlueTrkBar_Scroll(object sender, EventArgs e)
        {
            BlueValueTxt.Text = BlueTrkBar.Value.ToString();
            ne.BlueVal = BlueTrkBar.Value;
            IDPicBox.Image = ne.Img2BW(image);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            ne.RedVal = RedTrkBar.Value;
            ne.GreenVal = GreenTrkBar.Value;
            ne.BlueVal = BlueTrkBar.Value;
            this.Close();
            this.Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ChangeRGBForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
