using Chinook.BaseControls;
using Chinook.Data;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class AlbumControl : EntityControl
    {
        public AlbumControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            bdsArtist.DataSource = DataRepository.Artist.GetAll();
        }

        protected override void ToReadOnly()
        {
            txtTitle.ReadOnly = true;
            cbbArtistId.Enabled = false;
        }

        public override void ReadFromEntity(object entity)
        {
            Album album = (Album)entity;

            txtAlbumId.Text = album.AlbumId.ToString();
            txtTitle.Text = album.Title;
            cbbArtistId.SelectedValue = album.ArtistId;
        }

        public override void WriteToEntity(object entity)
        {
            Album album = (Album)entity;

            album.Title = txtTitle.Text;
            album.ArtistId = (int)cbbArtistId.SelectedValue;
        }
    }
}
