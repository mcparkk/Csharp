using Chinook.Data;
using System;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class AlbumListForm2 : Form
    {
        public AlbumListForm2()
        {
            InitializeComponent();

            // unbound mode
            //cbbArtistId.Items.Add()
            bdsArtist.DataSource = DataRepository.Artist.GetAll();
        }

        private void ChbArtistId_CheckedChanged(object sender, EventArgs e)
        {
            cbbArtistId.Enabled = chbArtistId.Checked;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int? artistId = null;
            if (chbArtistId.Checked)
                artistId = (int)cbbArtistId.SelectedValue;

            var albums = DataRepository.Album.Search2(txtTitle.Text, artistId);

            bdsAlbum.DataSource = albums;
        }

        private void DgvAlbum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Album album = (Album)dgvAlbum.CurrentRow.DataBoundItem;

            MessageBox.Show(album.AlbumId.ToString());
        }
    }
}
