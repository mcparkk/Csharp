namespace Chinook.Forms
{
    partial class InvoiceListForm
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
            this.invoiceSearchControl1 = new Chinook.Controls.InvoiceSearchControl();
            this.uscInvoiceList = new Chinook.Controls.InvoiceListControl();
            this.SuspendLayout();
            // 
            // invoiceSearchControl1
            // 
            this.invoiceSearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.invoiceSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.invoiceSearchControl1.Name = "invoiceSearchControl1";
            this.invoiceSearchControl1.Size = new System.Drawing.Size(1057, 114);
            this.invoiceSearchControl1.TabIndex = 0;
            this.invoiceSearchControl1.SearchButtonClicked += new System.EventHandler<Chinook.Controls.InvoiceSearchControl.SearchButtonClickedEventArgs>(this.UscInvoiceSearch_SearchButtonClicked);
           
            // 
            // uscInvoiceList
            // 
            this.uscInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscInvoiceList.Location = new System.Drawing.Point(0, 114);
            this.uscInvoiceList.Name = "uscInvoiceList";
            this.uscInvoiceList.Size = new System.Drawing.Size(1057, 336);
            this.uscInvoiceList.TabIndex = 1;
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.uscInvoiceList);
            this.Controls.Add(this.invoiceSearchControl1);
            this.Name = "InvoiceListForm";
            this.Text = "InvoiceListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.InvoiceSearchControl invoiceSearchControl1;
        private Controls.InvoiceListControl uscInvoiceList;
    }
}