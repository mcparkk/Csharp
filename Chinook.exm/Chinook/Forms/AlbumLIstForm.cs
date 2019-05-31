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
    public partial class AlbumLIstForm : Form
    {
        public AlbumLIstForm()
        {
            InitializeComponent();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //List<Album> list = DataRepository.Album.GetAll(x => x.Title.Contains(txtName.Text));

            //bdsAlbum.DataSource = list;

            //List<Album> albums = DataRepository.Album.Search(txtTitle.Text, ); 
            //                    DataRepository.Artist.GetAll(x => x.Name.Contains(txtArtistName.Text));
            //albumBindingSource.DataSource = albums
            

           

            
            
        }

        
    }
}
