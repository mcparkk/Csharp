using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.CompositionControls
{
    public partial class CheckableComboBox : UserControl
    {
        public CheckableComboBox()
        {
            InitializeComponent();
        }

        public void SetDataSource(object dataSource, string displayMemeber, string valueMember)
        {
            cbbList.DataSource = dataSource;
            cbbList.DisplayMember = displayMemeber;
            cbbList.ValueMember = valueMember;
        }

        private void ChbCheck_CheckedChanged(object sender, EventArgs e)
        {
            cbbList.Enabled = chbCheck.Checked;
        }

        public int? SelectedValue
        {
            get
            {
                if (chbCheck.Checked)
                    return (int)cbbList.SelectedValue;
                else 
                    return null;
            }
        }

        public string SelectedStringValue
        {
            get
            {
                if (chbCheck.Checked)
                    return (string)cbbList.SelectedValue;
                else
                    return null;
            }
        }

        public object SelectedItem
        {
            get
            {
                return cbbList.SelectedItem;
            }
        }
    }
}
