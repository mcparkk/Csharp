using Chinook.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class TrackListCotrol : UserControl
    {
        public TrackListCotrol()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Track> tracks)
        {
            bdsTrack.DataSource = tracks;
        }
    }
}
