namespace MathQuiz.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.uscPlus = new MathQuiz.QuizControl();
            this.uscDividen = new MathQuiz.QuizControl();
            this.uscProduct = new MathQuiz.QuizControl();
            this.uscMinus = new MathQuiz.QuizControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uscPlus
            // 
            this.uscPlus.Location = new System.Drawing.Point(37, 85);
            this.uscPlus.Name = "uscPlus";
            this.uscPlus.Padding = new System.Windows.Forms.Padding(5);
            this.uscPlus.Size = new System.Drawing.Size(449, 59);
            this.uscPlus.TabIndex = 0;
            // 
            // uscDividen
            // 
            this.uscDividen.Location = new System.Drawing.Point(37, 280);
            this.uscDividen.Name = "uscDividen";
            this.uscDividen.Operator = "/";
            this.uscDividen.Padding = new System.Windows.Forms.Padding(5);
            this.uscDividen.Size = new System.Drawing.Size(449, 59);
            this.uscDividen.TabIndex = 3;
            // 
            // uscProduct
            // 
            this.uscProduct.Location = new System.Drawing.Point(37, 215);
            this.uscProduct.Name = "uscProduct";
            this.uscProduct.Operator = "*";
            this.uscProduct.Padding = new System.Windows.Forms.Padding(5);
            this.uscProduct.Size = new System.Drawing.Size(449, 59);
            this.uscProduct.TabIndex = 2;
            // 
            // uscMinus
            // 
            this.uscMinus.Location = new System.Drawing.Point(37, 150);
            this.uscMinus.Name = "uscMinus";
            this.uscMinus.Operator = "-";
            this.uscMinus.Padding = new System.Windows.Forms.Padding(5);
            this.uscMinus.Size = new System.Drawing.Size(449, 59);
            this.uscMinus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Left";
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(189, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(266, 34);
            this.lblTime.TabIndex = 4;
            
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.TmrTimer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(163, 363);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(169, 39);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start the quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 427);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.uscMinus);
            this.Controls.Add(this.uscProduct);
            this.Controls.Add(this.uscDividen);
            this.Controls.Add(this.uscPlus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizControl uscPlus;
        private QuizControl uscDividen;
        private QuizControl uscProduct;
        private QuizControl uscMinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Button btnStart;
    }
}