using System;
using System.Windows.Forms;

namespace Chinook.CompositeControls
{
    public partial class CheckableComboBox : UserControl
    {
        public CheckableComboBox()
        {
            InitializeComponent();
        }

        private void ChbArtistId_CheckedChanged(object sender, EventArgs e)
        {
            cbbArtistId.Enabled = chbArtistId.Checked;
        }

        public object SelectedItem
        {
            get
            {
                if (chbArtistId.Checked)
                    return cbbArtistId.SelectedItem;
                else
                    return null;
            }
        }

        public int? SelectedValue
        {
            get
            {
                if (chbArtistId.Checked)
                    return (int)cbbArtistId.SelectedValue;
                else
                    return null;
            }
        }

        public void SetDataSource(object dataSource, string displayMember, string valueMember)
        {
            cbbArtistId.DataSource = dataSource;
            cbbArtistId.DisplayMember = displayMember;
            cbbArtistId.ValueMember = valueMember;
        }
    }
}
