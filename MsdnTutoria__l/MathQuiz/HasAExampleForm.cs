namespace MathQuiz
{
    public partial class HasAExampleForm : RightForm
    {
        public HasAExampleForm()
        {
            InitializeComponent();
        }

        private void EchoControl1_EchoButtonClicked(object sender, EchoControl.EchoButtonClickedEventArgs e)
        {
            lblResult.Text = e.EchoText + txtInput.Text;
        }
    }
}
