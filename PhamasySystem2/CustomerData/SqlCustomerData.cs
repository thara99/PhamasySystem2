using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Model;

namespace PhamasySystem2.CustomerData
{
    public class SqlCustomerData : ICustomer
    {

        private CustomerContext _customerContext;
        public SqlCustomerData(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public Customers AddCustomer(Customers customer)
        {
            customer.CId = Guid.NewGuid();
            _customerContext.Customers.Add(customer);
            _customerContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(Customers customer)
        {
            _customerContext.Customers.Remove(customer);
            _customerContext.SaveChanges();
        }

        public Customers EditCustomer(Customers customer)
        {
            var exixtingCustomer = _customerContext.Customers.Find(customer.CId);
            if (exixtingCustomer != null)
            {

                exixtingCustomer.CName = customer.CName;
                exixtingCustomer.PNum = customer.PNum;
                exixtingCustomer.Address = customer.Address;
                exixtingCustomer.NIC = customer.NIC;
                exixtingCustomer.AllergyMedicines = customer.AllergyMedicines;
                exixtingCustomer.Age = customer.Age;
                _customerContext.Customers.Update(exixtingCustomer);
                _customerContext.SaveChanges();

            }
            return customer;
        }

        public Customers GetCustomer(Guid Cid)
        {
            var customer = _customerContext.Customers.Find(Cid);
            return customer;
        }

        public List<Customers> GetCustomers()
        {
            return _customerContext.Customers.ToList();
        }
    }
}
