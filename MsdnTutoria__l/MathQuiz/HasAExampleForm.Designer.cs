namespace MathQuiz
{
    partial class HasAExampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.echoControl1 = new MathQuiz.EchoControl();
            this.echoControl2 = new MathQuiz.EchoControl();
            this.echoControl3 = new MathQuiz.EchoControl();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // echoControl1
            // 
            this.echoControl1.Location = new System.Drawing.Point(10, 15);
            this.echoControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.echoControl1.Name = "echoControl1";
            this.echoControl1.Size = new System.Drawing.Size(465, 70);
            this.echoControl1.TabIndex = 3;
            this.echoControl1.Title = "A";
            this.echoControl1.EchoButtonClicked += new System.EventHandler<MathQuiz.EchoControl.EchoButtonClickedEventArgs>(this.EchoControl1_EchoButtonClicked);
            // 
            // echoControl2
            // 
            this.echoControl2.Location = new System.Drawing.Point(10, 92);
            this.echoControl2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.echoControl2.Name = "echoControl2";
            this.echoControl2.Size = new System.Drawing.Size(465, 70);
            this.echoControl2.TabIndex = 4;
            this.echoControl2.Title = "B";
            // 
            // echoControl3
            // 
            this.echoControl3.Location = new System.Drawing.Point(10, 170);
            this.echoControl3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.echoControl3.Name = "echoControl3";
            this.echoControl3.Size = new System.Drawing.Size(465, 70);
            this.echoControl3.TabIndex = 5;
            this.echoControl3.Title = "C";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 281);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 25);
            this.txtInput.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(118, 284);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(357, 23);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "label1";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HasAExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 380);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.echoControl3);
            this.Controls.Add(this.echoControl2);
            this.Controls.Add(this.echoControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "HasAExampleForm";
            this.Text = "HasAExampleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EchoControl echoControl1;
        private EchoControl echoControl2;
        private EchoControl echoControl3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResult;
    }
}