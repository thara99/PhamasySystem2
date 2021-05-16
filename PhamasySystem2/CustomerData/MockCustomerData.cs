using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Model;

namespace PhamasySystem2.CustomerData
{
    public class MockCustomerData : ICustomer
    {

        private List<Customers> customers = new List<Customers>()
        {
            new Customers()
            {
                CId = Guid.NewGuid(),
                CName = "Janitha Tharaka",
                PNum="0715424878",
                Address="colombo",
                NIC="993032547V",
                AllergyMedicines="Piriton",
                Age=25
            },
             new Customers()
            {
                CId = Guid.NewGuid(),
                CName = "Joan",
                PNum="0715424845",
                Address="kadawatha",
                NIC="993032578V",
                AllergyMedicines="panadol",
                Age=30
            }
        };

        public Customers AddCustomer(Customers customer)
        {
            customer.CId = Guid.NewGuid();
            customers.Add(customer);
            return customer;
        }

        public void DeleteCustomer(Customers customer)
        {
            customers.Remove(customer);
        }

        public Customers EditCustomer(Customers customer)
        {
            var exixingCustomer = GetCustomer(customer.CId);
            exixingCustomer.CName = customer.CName;
            exixingCustomer.PNum = customer.PNum;
            exixingCustomer.Address = customer.Address;
            exixingCustomer.NIC = customer.NIC;
            exixingCustomer.AllergyMedicines = customer.AllergyMedicines;
            exixingCustomer.Age = customer.Age;
            return exixingCustomer;
        }

        public Customers GetCustomer(Guid Cid)
        {
            return customers.SingleOrDefault(x => x.CId == Cid);
        }

        public List<Customers> GetCustomers()
        {
            return customers;
        }
    }
}
