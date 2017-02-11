using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VotingSystemVer2.VotingForms
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(Dictionary<string, int> data)
        {
            InitializeComponent();
            List<KeyValuePair<string, int>> list = data.ToList();
            ResultGrdView.DataSource = list;
            ResultGrdView.Columns[0].HeaderText = "Choice";
            ResultGrdView.Columns[1].HeaderText = "Results";
            ResultGrdView.ScrollBars = ScrollBars.Vertical;
        }
    }
}
