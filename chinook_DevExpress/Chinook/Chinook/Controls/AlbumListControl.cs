using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chinook.Controls
{
    [DefaultEvent("RowDoubleClicked")]
    public partial class AlbumListControl : UserControl
    {
        public AlbumListControl()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<Album> list)
        {
            bdsAlbum.DataSource = list;

            tslCount.Text = $"{list.Count:N0} 건";
        }

        private void DgvAlbum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Album album = dgvAlbum.CurrentRow.DataBoundItem as Album;

            if (album == null)
                return;

            OnRowDoubleClicked(album);
        }

        private void DgvAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Album album = dgvAlbum.CurrentRow.DataBoundItem as Album;

            if (album == null)
                return;

            OnRowClicked(album);
        }

        public void SetProgress(int value)
        {
            tspProgress.Value = value;
        }
        

        #region RowDoubleClicked event things for C# 3.0
        [Category("Chinook")]
        public event EventHandler<RowDoubleClickedEventArgs> RowDoubleClicked;

        protected virtual void OnRowDoubleClicked(RowDoubleClickedEventArgs e)
        {
            if (RowDoubleClicked != null)
                RowDoubleClicked(this, e);
        }

        private RowDoubleClickedEventArgs OnRowDoubleClicked(Album album)
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs(album);
            OnRowDoubleClicked(args);

            return args;
        }

        private RowDoubleClickedEventArgs OnRowDoubleClickedForOut()
        {
            RowDoubleClickedEventArgs args = new RowDoubleClickedEventArgs();
            OnRowDoubleClicked(args);

            return args;
        }

        public class RowDoubleClickedEventArgs : EventArgs
        {
            public Album Album { get; set; }

            public RowDoubleClickedEventArgs()
            {
            }

            public RowDoubleClickedEventArgs(Album album)
            {
                Album = album;
            }
        }
        #endregion

        #region RowClicked event things for C# 3.0
public event EventHandler<RowClickedEventArgs> RowClicked;

protected virtual void OnRowClicked(RowClickedEventArgs e)
{
	if (RowClicked != null)
		RowClicked(this, e);
}

private RowClickedEventArgs OnRowClicked(Album album )
{
	RowClickedEventArgs args = new RowClickedEventArgs(album );
    OnRowClicked(args);

    return args;
}

private RowClickedEventArgs OnRowClickedForOut()
{
	RowClickedEventArgs args = new RowClickedEventArgs();
    OnRowClicked(args);

    return args;
}

public class RowClickedEventArgs : EventArgs
{
	public Album Album { get; set;} 

	public RowClickedEventArgs()
    {
	}
	
	public RowClickedEventArgs(Album album )
    {
		Album = album; 
	}
}
        #endregion
    }
}
