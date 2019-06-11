using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _quizControls.Add(uscPlus);
            _quizControls.Add(uscMinus);
            _quizControls.Add(uscProduct);
            _quizControls.Add(uscDividen);
        }

        private List<QuizControl> _quizControls = new List<QuizControl>();

        private int _remainingTime;

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var control in _quizControls)
                control.Generate();

            
        }

        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            _remainingTime--;

            if (HasRightAnswers())
            {
                tmrTimer.Stop();
                MessageBox.Show("축하한다능");
                Close();
            }
            else if (_remainingTime > 0)
            {
                lblTime.Text = $"{_remainingTime}초 남았다는";
            }
            else
            {
                tmrTimer.Stop();
                MessageBox.Show("끝났다는");
                Close();
            }
        }

        private bool HasRightAnswers()
        {
            foreach (var control in _quizControls)
                if (control.HasRightAnswer() == false)
                    return false;

            return true;

            //return _quizControls.All(x => x.HasRightAnswer());
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            _remainingTime = 30;
            tmrTimer.Start(); // tmrTimer.Enabled = true;
        }

        
    }
}
