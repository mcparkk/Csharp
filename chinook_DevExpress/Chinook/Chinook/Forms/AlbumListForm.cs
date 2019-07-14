using Chinook.Data;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Chinook.Controls;

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

            if (DesignMode)
                return;
        }


        private async void UscSearch_SearchButtonClicked(object sender, AlbumSearchControl.SearchButtonClickedEventArgs e)
        {
            //bgwWorker.RunWorkerAsync(e);
            List<Album> albums = await DataRepository.Album.Search2Async(e.Title, e.ArtistId);
            uscList.SetDataSource(albums);
        }

        private void BgwWorker_DoWorkAsync(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            AlbumSearchControl.SearchButtonClickedEventArgs arg = (AlbumSearchControl.SearchButtonClickedEventArgs)e.Argument;

            List<Album> albums = null;
            for (int i = 0; i < 5; i++)
            {
                albums = DataRepository.Album.Search2(arg.Title, arg.ArtistId);

                bgwWorker.ReportProgress((i+1) * 20);
            }

            e.Result = albums;
        }

        private void BgwWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            uscList.SetProgress(e.ProgressPercentage);
        }

        private void BgwWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            var albums = (List<Album>)e.Result;
            uscList.SetDataSource(albums);
        }

        private void UscList_RowDoubleClicked(object sender, AlbumListControl.RowDoubleClickedEventArgs e)
        {
            AlbumForm2 form = new AlbumForm2(e.Album);
            form.ShowDialog();
        }

        private void UscList_RowClicked(object sender, AlbumListControl.RowClickedEventArgs e)
        {
            uscAlbum.ReadFromEntity(e.Album);
        }
    }
}
