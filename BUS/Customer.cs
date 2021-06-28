using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class Customer
    {
        private static Customer instance;
        private static BindingList<DTO.Customer> customers;

        public Customer()
        {
            Customers = new BindingList<DTO.Customer>();
            GetListCustomer();
        }

        public static Customer Instance { get => instance; set => instance = value; }
        public static BindingList<DTO.Customer> Customers { get => customers; set => customers = value; }

        public void GetListCustomer()
        {
            customers = DAO.Customer.Instance.GetListCustomer();
        }

        public bool AddCustomer(string name, string address, string phoneNumber, string email, int debt)
        {           
            //if (Customers.FirstOrDefault
            //    (customer => customer.Name.Equals(name)
            //    && customer.Address.Equals(address)
            //    && customer.PhoneNumber.Equals(phoneNumber)
            //    && customer.Email.Equals(email)
            //    && customer.Debt == debt) == null)
            //{
                int id = DAO.Customer.Instance.AddCustomer(name, address, phoneNumber, email, debt);
                if (id != -1)
                {
                    Customers.Add(new DTO.Customer(
                       id,
                       name,
                       address,
                       phoneNumber,
                       email,
                       debt
                    ));

                    return true;
                }
                //return false;
            //}
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            if (DAO.Customer.Instance.DeleteCustomer(id))
            {
                Customers.Remove(Customers.First(customer => customer.Id == id));
                return true;
            }
            return false;
        }

        public bool UpdateCustomer(DTO.Customer updated)
        {
            //if (Customers.FirstOrDefault
            //    (customer => customer.Name.Equals(updated.Name)
            //    && customer.Address.Equals(updated.Address)
            //    && customer.PhoneNumber.Equals(updated.PhoneNumber)
            //    && customer.Email.Equals(updated.Email)
            //    && customer.Debt == updated.Debt) != null)
            //{
                if (DAO.Customer.Instance.UpdateCustomer(updated))
                {
                    var obj = Customers.First(customer => customer.Id == updated.Id);

                    obj.Name = updated.Name;
                    obj.Address = updated.Address;
                    obj.PhoneNumber = updated.PhoneNumber;
                    obj.Email = updated.Email;
                    obj.Debt = updated.Debt;

                    return true;
                }
            //}
            return false;
        }
    }
}
