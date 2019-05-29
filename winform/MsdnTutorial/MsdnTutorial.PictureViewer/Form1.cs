using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsdnTutorial.PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // 이벤트 처리기(event handler)
        // java : event listener
        // call back == function pointer == delegate
        private void ChbStretch_CheckedChanged(object sender, EventArgs e)
        {
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
            if (cldBackcolor.ShowDialog() != DialogResult.OK)
                return;

            ptbImage.BackColor = cldBackcolor.Color;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ptbImage.Image = null;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdOpen.ShowDialog();

            if (result != DialogResult.OK)
                return;

            ptbImage.Load(ofdOpen.FileName);
            
        }
    }
}
