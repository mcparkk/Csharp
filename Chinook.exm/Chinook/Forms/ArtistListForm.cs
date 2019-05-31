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
    public partial class ArtistListForm : Form
    {
        public ArtistListForm()
        {
            InitializeComponent();
        }

        #region OnLoad
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString() == "9883897D2ECA")
                Left += 1980;
        }
        #endregion

        //private void TxtName_Leave(object sender, EventArgs e)
        //{
        //    if (txtName.Text.StartsWith("a"))
        //    {
        //        txtName.BackColor = Color.Red;
        //        btnSearch.Enabled = false;
        //    }
        //    else
        //    {
        //        txtName.BackColor = Color.White;
        //        btnSearch.Enabled = true;
        //    }
        //}

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Artist> list = DataRepository.Artist.GetAll(x => x.Name.Contains(txtName.Text));

            bdsArtist.DataSource = list;

            //cbbArtist.SelectedIndex = 1;

            //foreach (var artist in list)
            //{
            //    cbbArtist.Items.Add(artist);
            //}
        }

        private void CbbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artist artist = (Artist)cbbArtist.SelectedItem;
            //Text = artist.ArtistId.ToString();

            int artistId = (int)cbbArtist.SelectedValue;
            Text = artistId.ToString();

        }
    }
}
