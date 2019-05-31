using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class TrackListForm : Form
    {
        public TrackListForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var tracks = DataRepository.Track.GetAll();

            uscTrackSearch.SetArtistDataSource(tracks); 

           
        }
    }
}
