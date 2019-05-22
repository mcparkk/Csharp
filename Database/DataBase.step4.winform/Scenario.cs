
using Database.Step4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase.step4.winform
{
    public partial class Scenario : Form
    {
        public Scenario()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            
             int sumOfPlaytime = DataRepository.Album.GetTrackTime(albumName.Text);

             int trackCount = DataRepository.Album.GetCount();

            if (sumOfPlaytime == -1)
            {
                MessageBox.Show(" 정확한 앨범명을 기입해주세요.", "앨범을 찾을 수 없습니다.", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                resultTime.Text = TimeSpan.FromMilliseconds(sumOfPlaytime).TotalMinutes.ToString("F0");
                count.Text = trackCount.ToString();
            }
            
        }

       
    }
}
