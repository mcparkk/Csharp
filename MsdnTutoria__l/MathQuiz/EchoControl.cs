using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class EchoControl : UserControl
    {
        public EchoControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);

            OnEchoButtonClicked(textBox1.Text);
        }

        public string Title
        {
            get
            {
                return groupBox1.Text;
            }
            set
            {
                groupBox1.Text = value;
            }
        }

        #region EchoButtonClicked event things for C# 3.0
        public event EventHandler<EchoButtonClickedEventArgs> EchoButtonClicked;

        protected virtual void OnEchoButtonClicked(EchoButtonClickedEventArgs e)
        {
            if (EchoButtonClicked != null)
                EchoButtonClicked(this, e);
        }

        private EchoButtonClickedEventArgs OnEchoButtonClicked(string echoText)
        {
            EchoButtonClickedEventArgs args = new EchoButtonClickedEventArgs(echoText);
            OnEchoButtonClicked(args);

            return args;
        }

        private EchoButtonClickedEventArgs OnEchoButtonClickedForOut()
        {
            EchoButtonClickedEventArgs args = new EchoButtonClickedEventArgs();
            OnEchoButtonClicked(args);

            return args;
        }

        public class EchoButtonClickedEventArgs : EventArgs
        {
            public string EchoText { get; set; }

            public EchoButtonClickedEventArgs()
            {
            }

            public EchoButtonClickedEventArgs(string echoText)
            {
                EchoText = echoText;
            }
        }
        #endregion
    }
}
