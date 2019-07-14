using Chinook.BaseControls;
using Chinook.BaseForms;
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
    public partial class AlbumForm2 : EntityForm
    {
        public AlbumForm2()
        {
            InitializeComponent();
        }

        public AlbumForm2(Album entity) : this()
        {
            _entity = entity;
        }

        private Album _entity;

        protected override EntityControl EntityControl => uscAlbum;

        protected override object Entity => _entity;

        protected override void OnSaveClick()
        {
            DataRepository.Album.Update(_entity);
        }

        protected override void OnDeleteClick()
        {
            DataRepository.Album.Delete(_entity);
        }
    }
}
