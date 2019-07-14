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
    public partial class AlbumSearchControl : UserControl
    {
        public AlbumSearchControl()
        {
            InitializeComponent();

            // 1
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            OnSearchButtonClicked(txtTitle.Text, uscArtistId.SelectedValue);
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = txtTitle.Text.Length > 3;
        }

        private void AlbumSearchControl_Load(object sender, EventArgs e)
        {
            // 2
            var list = DataRepository.Artist.GetAll();
            uscArtistId.SetDataSource(list, nameof(Artist.Name), nameof(Artist.ArtistId));
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string title, int? artistId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(title, artistId);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string Title { get; set; }
            public int? ArtistId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string title, int? artistId)
            {
                Title = title;
                ArtistId = artistId;
            }
        }
        #endregion
    }
}
