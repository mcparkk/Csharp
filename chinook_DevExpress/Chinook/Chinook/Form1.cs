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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            //textBox1.Text = (string)button.Tag;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            RemoveControls();
            CreateButton((int)speCount.Value);
        }

        private void RemoveControls()
        {
            while (Controls.Count != 2)
            {
                Controls.RemoveAt(2);
            }
        }

        private void CreateButton(int no)
        {
            for(int i = 0; i < no; i++)
            {
                int row = (i % 3);
                int column = (i / 3);
                int xStartPoint = 12;
                int yStartPoint = 17;

                SimpleButton button = new SimpleButton();
                button.Location = new Point(xStartPoint + (29 * row), yStartPoint + (29 * column));
                button.Size = new Size(25, 25);
                button.Text = (i + 1).ToString();

 //               button.Click += (sender,EventArgs) => txtNumber.Text = button.Text;

                Controls.Add(button);
            }
        }
    }
}
