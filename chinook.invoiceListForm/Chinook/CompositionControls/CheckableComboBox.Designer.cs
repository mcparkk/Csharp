namespace Chinook.CompositionControls
{
    partial class CheckableComboBox
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
            this.chbCheck = new System.Windows.Forms.CheckBox();
            this.cbbList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chbCheck
            // 
            this.chbCheck.AutoSize = true;
            this.chbCheck.Checked = true;
            this.chbCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCheck.Location = new System.Drawing.Point(3, 5);
            this.chbCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCheck.Name = "chbCheck";
            this.chbCheck.Size = new System.Drawing.Size(18, 17);
            this.chbCheck.TabIndex = 5;
            this.chbCheck.UseVisualStyleBackColor = true;
            this.chbCheck.CheckedChanged += new System.EventHandler(this.ChbCheck_CheckedChanged);
            // 
            // cbbList
            // 
            this.cbbList.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbList.FormattingEnabled = true;
            this.cbbList.Location = new System.Drawing.Point(67, 0);
            this.cbbList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbList.Name = "cbbList";
            this.cbbList.Size = new System.Drawing.Size(198, 23);
            this.cbbList.TabIndex = 4;
            // 
            // CheckableComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbCheck);
            this.Controls.Add(this.cbbList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckableComboBox";
            this.Size = new System.Drawing.Size(265, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbCheck;
        private System.Windows.Forms.ComboBox cbbList;
    }
}
