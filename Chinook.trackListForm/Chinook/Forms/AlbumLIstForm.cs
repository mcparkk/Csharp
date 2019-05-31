using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Chinook.Forms
{
    public partial class AlbumListForm : Form
    {
        public AlbumListForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Artist> artists = 
                DataRepository.Artist.GetAllOrderByName();

            uscAlbumSearch.SetArtistDataSource(artists);
        }

        private void UscAlbumSearch_SearchButtonClicked(object sender, Controls.AlbumSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Album> albums = DataRepository.Album.Search(e.AlbumTitle, e.ArtistId);

            uscAlbumList.SetDataSource(albums);
        }
    }
}
