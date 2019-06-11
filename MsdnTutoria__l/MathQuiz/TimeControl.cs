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
    public partial class TimeControl : UserControl
    {
        public TimeControl()
        {
            InitializeComponent();
        }
        private int _remainingTime;
        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            _remainingTime--;

            if(_remainingTime >0)
            {
                timeLabel.Text = $"{_remainingTime}초 남았습니다.";
            }
            
            


        }
        #region TimeLeft event things for C# 3.0
        public event EventHandler<TimeLeftEventArgs> TimeLeft;

        protected virtual void OnTimeLeft(TimeLeftEventArgs e)
        {
            if (TimeLeft != null)
                TimeLeft(this, e);
        }

        private TimeLeftEventArgs OnTimeLeft(int _remainingTime)
        {
            TimeLeftEventArgs args = new TimeLeftEventArgs(_remainingTime);
            OnTimeLeft(args);

            return args;
        }

        private TimeLeftEventArgs OnTimeLeftForOut()
        {
            TimeLeftEventArgs args = new TimeLeftEventArgs();
            OnTimeLeft(args);

            return args;
        }

        public class TimeLeftEventArgs : EventArgs
        {
            public int _remainingTime { get; set; }

            public TimeLeftEventArgs()
            {
            }

            public TimeLeftEventArgs(int _remainingTime)
            {
                _remainingTime = _remainingTime;
            }
        }
        #endregion
    }
}
