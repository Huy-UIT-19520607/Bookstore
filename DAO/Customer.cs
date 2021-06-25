using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Customer
    {
        private static Customer instance;
        private static BindingList<DTO.Customer> customers;

        public Customer()
        {
            customers = new BindingList<DTO.Customer>();
            GetListCustomer();
        }

        public static Customer Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new Customer();
                }
                return instance;
            }
            set => instance = value; 
        }
        public static BindingList<DTO.Customer> Customers { get => customers; set => customers = value; }

        private void GetListCustomer()
        {
            string query = "select * from KHACHHANG";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in results.Rows)
            {
                Customers.Add(new DTO.Customer(
                    (int)row.ItemArray[0],
                    row.ItemArray[1].ToString(),
                    row.ItemArray[2].ToString(),
                    row.ItemArray[3].ToString(),
                    row.ItemArray[4].ToString(),
                    (int)row.ItemArray[5]
                ));
            }
        }

        public bool AddCustomer(string name, string address, string phoneNumber, string email, int debt)
        {
            string query = "EXEC sp_add_customer @name , @address , @phoneNumber , @email , @debt";
            object results = DataProvider.Instance.ExecuteScalar(query, new object[] 
            {
                name,
                address,
                phoneNumber,
                email,
                debt
            });

            if (results != null)
            {
                Customers.Add(new DTO.Customer(
                   (int)results,
                   name,
                   address,
                   phoneNumber,
                   email,
                   debt
               ));
            }

            return results != null;
        }

        public bool DeleteCustomer(int id)
        {
            string query = "EXEC sp_remove_customer @id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            if (results > 0)
            {
                Customers.Remove(Customers.First(customer => customer.Id == id));
            }

            return results > 0;
        }

        public bool UpdateCustomer(DTO.Customer updated)
        {
            string query = "EXEC sp_update_customer @id , @name , @address , @phoneNumber , @email , @debt";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Id,
                updated.Name,
                updated.Address,
                updated.PhoneNumber,
                updated.Email,
                updated.Debt
            });

            if (results > 0)
            {
                var obj = Customers.First(customer => customer.Id == updated.Id);

                obj.Name = updated.Name;
                obj.Address = updated.Address;
                obj.PhoneNumber = updated.PhoneNumber;
                obj.Email = updated.Email;
                obj.Debt = updated.Debt;
            }

            return results > 0;
        }
    }
}
