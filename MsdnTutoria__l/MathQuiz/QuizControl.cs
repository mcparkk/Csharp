using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathQuiz.Utilities;

namespace MathQuiz
{
    public partial class QuizControl : UserControl
    {
        public QuizControl()
        {
            InitializeComponent();
        }

        [DefaultValue("+")]
        public string Operator
        {
            get
            {
                return lblOperator.Text;
            }
            set
            {
                lblOperator.Text = value;
            }
        }

        private int _left;

        private int _right;

        private int _answer;

        public void Generate()
        {
            if (Operator == "+")
            {
                _left = Randomizer.Instance.Next(51);
                _right = Randomizer.Instance.Next(51);
                _answer = _left + _right;
            }
            else if (Operator == "-")
            {
                _left = Randomizer.Instance.Next(1, 101);
                _right = Randomizer.Instance.Next(1, _left);
                _answer = _left - _right;

            }
            else if (Operator == "*")
            {
                _left = Randomizer.Instance.Next(2, 11);
                _right = Randomizer.Instance.Next(2, 11);
                _answer = _left * _right;
            }
            else if (Operator == "/")
            {
                _right = Randomizer.Instance.Next(2, 11);
                int t = Randomizer.Instance.Next(2, 11);
                _left = _right * t;
                _answer = _left / _right;
            }
            else
            {
                throw new Exceptions.UnsupportedOperatorException(Operator);
            }

            lblLeft.Text = _left.ToString();
            lblRight.Text = _right.ToString();
        }

        public bool HasRightAnswer()
        {
            return nupAnswer.Value == _answer;
        }

        private void NupAnswer_Enter(object sender, EventArgs e)
        {
            int length = nupAnswer.Value.ToString().Length;
            nupAnswer.Select(0, length);
        }
    }
}
