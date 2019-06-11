using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            Enter += TextBoxEx_Enter;
            Leave += TextBoxEx_Leave;
        }

        private void TextBoxEx_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void TextBoxEx_Enter(object sender, EventArgs e)
        {
            BackColor = Color.Beige;
        }
    }
}
