using System.Windows.Forms;

namespace Chinook
{
    partial class Form1
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
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.speCount = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.speCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(238, 84);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 29);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "&Create!";
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // speCount
            // 
            this.speCount.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.speCount.Location = new System.Drawing.Point(209, 51);
            this.speCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.speCount.Name = "speCount";
            this.speCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speCount.Properties.MaxValue = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.speCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speCount.Size = new System.Drawing.Size(114, 24);
            this.speCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 326);
            this.Controls.Add(this.speCount);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.speCount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SpinEdit speCount;
    }
}