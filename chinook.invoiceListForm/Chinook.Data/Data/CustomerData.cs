using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class CustomerData : EntityData<Customer>
    {
        public Customer GetByPK(int customerId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Customers.FirstOrDefault(x => x.CustomerId == customerId);
            }
        }

        public void DeleteByPK(int customerId)
        {
            Customer entity = GetByPK(customerId);

            if (entity == null)
                return;

            Delete(entity);
        }


    }

   

}














