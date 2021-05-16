using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Model;

namespace PhamasySystem2.CustomerData
{
    public interface ICustomer
    {

        List<Customers> GetCustomers();

        Customers GetCustomer(Guid Cid);

        Customers AddCustomer(Customers customer);

        void DeleteCustomer(Customers customer);

        Customers EditCustomer(Customers customer);

    }
}
