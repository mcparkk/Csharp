using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Step4.Data;

namespace Database.Step4.Winform
{
    public partial class Scenario2 : Form
    {
        public Scenario2()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            int value = DataRepository.Album.GetTrackCount(txtKeyword.Text);

            txtResult.Text = value.ToString();
        }
    }
}
