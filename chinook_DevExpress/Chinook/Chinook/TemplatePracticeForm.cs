using Chinook.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook
{
    public partial class TemplatePracticeForm : XtraForm
    {
        public TemplatePracticeForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            Artist artist = DataRepository.Artist.GetFirst(x => x.ArtistId > 1);

            textBox1.Text = artist.Name;
            rdgArtistId.EditValue = artist.ArtistId;

            rdb1.Checked = artist.ArtistId == 1;
            rdb2.Checked = artist.ArtistId == 2;
            rdb3.Checked = artist.ArtistId == 3;


            artistBindingSource.DataSource = DataRepository.Artist.GetAll();
        }

        private void ListBoxControl1_DoubleClick(object sender, EventArgs e)
        {
            //Artist artist = listBoxControl1.SelectedItem as Artist;
            //if (artist == null)
            //    return;

            //XtraMessageBox.Show(artist.Name);

            if (listBoxControl1.SelectedItem is Artist artist)
                MessageBox.Show(artist.Name);

        }
    }
}
