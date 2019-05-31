using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Data;

namespace Chinook.Controls
{
    public partial class uscTrackSearchControl : UserControl
    {
        public uscTrackSearchControl()
        {
            InitializeComponent();
        }
        internal void SetArtistDataSource(List<Track> tracks)
        {
          
            trackBindingSource.DataSource = tracks;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void ChkAlbumId_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ChkArtistId_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
