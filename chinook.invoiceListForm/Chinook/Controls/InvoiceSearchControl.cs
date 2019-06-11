using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Data;
namespace Chinook.Controls
{
    public partial class InvoiceSearchControl : UserControl
    {
        public InvoiceSearchControl()
        {
            InitializeComponent();
        }


        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(DateTime dateStart, DateTime dateEnd, string billingCountry)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(dateStart, dateEnd, billingCountry);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public DateTime DateStart { get; set; }
            public DateTime DateEnd { get; set; }
            public string BillingCountry { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(DateTime dateStart, DateTime dateEnd, string billingCountry)
            {
                DateStart = dateStart;
                DateEnd = dateEnd;
                BillingCountry = billingCountry;
            }
        }
        #endregion

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            OnSearchButtonClicked(dtpStart.Value.Date,           dtpEnd.Value.Date,         uscInvoice.SelectedStringValue);
        }
        internal void SetInvoiceDataSource(List<Invoice> invoices)
        {
            uscInvoice.SetDataSource(invoices, nameof(Invoice.BillingCountry), nameof(Invoice.BillingCountry));
        }


    }
}
