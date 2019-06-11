namespace MathQuiz
{
    partial class QuizControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupAnswer = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeft
            // 
            this.lblLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLeft.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLeft.Location = new System.Drawing.Point(5, 5);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(82, 45);
            this.lblLeft.TabIndex = 0;
            this.lblLeft.Text = "100";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOperator.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOperator.Location = new System.Drawing.Point(87, 5);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(82, 45);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "+";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRight
            // 
            this.lblRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRight.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRight.Location = new System.Drawing.Point(169, 5);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(82, 45);
            this.lblRight.TabIndex = 2;
            this.lblRight.Text = "99";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(251, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nupAnswer
            // 
            this.nupAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nupAnswer.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nupAnswer.Location = new System.Drawing.Point(333, 5);
            this.nupAnswer.Name = "nupAnswer";
            this.nupAnswer.Size = new System.Drawing.Size(434, 45);
            this.nupAnswer.TabIndex = 4;
            this.nupAnswer.Enter += new System.EventHandler(this.NupAnswer_Enter);
            // 
            // QuizControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nupAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblLeft);
            this.Name = "QuizControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(772, 55);
            ((System.ComponentModel.ISupportInitialize)(this.nupAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupAnswer;
    }
}
