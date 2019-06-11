using System;
using System.Windows.Forms;

namespace Chinook.CompositionControls
{
    public partial class ChekableNumericUpDown : UserControl
    {
        public ChekableNumericUpDown()
        {
            InitializeComponent();
        }

        private void ChbCheck_CheckedChanged(object sender, EventArgs e)
        {
            nupValue.Enabled = chbCheck.Checked;
        }

        // Int32(int), String(string), Decimal(decimal)
        public decimal? Value
        {
            get
            {
                if (chbCheck.Checked)
                    return nupValue.Value;
                else
                    return null;
            }
        }
    }
}
