using Chinook.Data;
using MyLibrary.Helpers;
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
    public partial class AlbumForm : Form
    {
        private AlbumForm()
        {
            InitializeComponent();
        }

        public AlbumForm(Album entity) : this()
        {
            _entity = entity;
        }

        private Album _entity;

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            uscAlbum.ReadFromEntity(_entity);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            uscAlbum.WriteToEntity(_entity);

            DataRepository.Album.Update(_entity);

            DialogResult = DialogResult.OK;
            Close();
        } 

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (WinformHelper.AskToDelete() == false)
                return;

            DataRepository.Album.Delete(_entity);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
