using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 이벤트 처리기 (event handler)
        // java : event listener
        // call back == function pointer == delegate
        private void ChbStretch_CheckedChanged(object sender, EventArgs e)
        {
            // F7
            if (chbStretch.Checked)
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                ptbImage.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBackground_Click(object sender, EventArgs e)
        {
            if (cldBackColor.ShowDialog() != DialogResult.OK)
                return;

            ptbImage.BackColor = cldBackColor.Color;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ptbImage.Image = null;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() != DialogResult.OK)
                return;

            // intelli code
            ptbImage.Load(ofdOpen.FileName);
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
        }
    }
}
