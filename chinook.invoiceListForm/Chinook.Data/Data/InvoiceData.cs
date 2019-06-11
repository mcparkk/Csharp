using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class InvoiceData : EntityData<Invoice>
    {
        public Invoice GetByPK(int invoiceId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Invoices.FirstOrDefault(x => x.InvoiceId == invoiceId);
            }
        }

        public void DeleteByPK(int invoiceId)
        {
            Invoice entity = GetByPK(invoiceId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public Invoice GetByCountry(string country)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Invoices.First(x => x.BillingCountry == country);
            }
        }

        public List<Invoice> GetAllOrderByCountry()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = context.Invoices
                            .GroupBy(x => x.BillingCountry)
                            .Select(x => x.FirstOrDefault());
                          
                return query.ToList();                           
            }
        }

        public List<Invoice> GetTotal()
        {
            using(ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Invoices
                            orderby x.Total
                            select x;

                return query.ToList();
            }
        }
        public List<Invoice> Search(DateTime startDate, DateTime endDate, string billingCountry)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.Invoices
                            select new
                            {
                                CustomerFirstName = x.Customer.FirstName,
                                CustomerLastName = x.Customer.LastName,
                                Invoice = x
                            };

                if (startDate != null)
                    query = query.Where(x => x.Invoice.InvoiceDate >= startDate);
                if (endDate != null)
                    query = query.Where(x => x.Invoice.InvoiceDate <= endDate);
                if (billingCountry.IsNullOrEmpty() == false)
                    query = query.Where(x => x.Invoice.BillingCountry.Contains(billingCountry));

                
                var list = query.ToList();

                foreach (var x in list)
                {
                    x.Invoice.CustomerName = x.CustomerFirstName + " " + x.CustomerLastName;
                    
                }

                return list.ConvertAll(x => x.Invoice);

            }
        }
    }
}














