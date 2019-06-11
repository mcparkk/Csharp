using Chinook.Controls;
using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class InvoiceListForm : Form
    {
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

           
            List<Invoice> countries =
                DataRepository.Invoice.GetAllOrderByCountry();
            invoiceSearchControl1.SetInvoiceDataSource(countries);


            //List<Invoice> invoices = new List<Invoice>();

            //foreach ( var country in countries)
            //{
            //    invoices.Add(DataRepository.Invoice.GetByCountry(country));
            //}
        }
        private void UscInvoiceSearch_SearchButtonClicked(object sender, Controls.InvoiceSearchControl.SearchButtonClickedEventArgs e)
        {
            List<Invoice> invoices = DataRepository.Invoice.Search(e.DateStart, e.DateEnd, e.BillingCountry);

            uscInvoiceList.SetDataSource(invoices);
        }
    }
}
