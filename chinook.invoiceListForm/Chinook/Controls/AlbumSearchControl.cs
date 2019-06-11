using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Chinook.Data;

namespace Chinook.Controls
{
    public partial class AlbumSearchControl : UserControl
    {
        public AlbumSearchControl()
        {
            InitializeComponent();
        }

        private void TxtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text.StartsWith("a"))
                txtTitle.BackColor = Color.Red;
            else
                txtTitle.BackColor = Color.White;
        }

        internal void SetArtistDataSource(List<Artist> artists)
        {
            uscArtist.SetDataSource(artists, nameof(Artist.Name), nameof(Artist.ArtistId));
        }

        #region SearchButtonClicked event things for C# 3.0
public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
{
	if (SearchButtonClicked != null)
		SearchButtonClicked(this, e);
}

private SearchButtonClickedEventArgs OnSearchButtonClicked(string albumTitle  , int? artistId )
{
	SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(albumTitle  , artistId );
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
	public string AlbumTitle { get; set;}  
public int? ArtistId { get; set;} 

	public SearchButtonClickedEventArgs()
    {
	}
	
	public SearchButtonClickedEventArgs(string albumTitle  , int? artistId )
    {
		AlbumTitle = albumTitle;  
ArtistId = artistId; 
	}
}
#endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            OnSearchButtonClicked(txtTitle.Text, uscArtist.SelectedValue);
        }
    }
}
