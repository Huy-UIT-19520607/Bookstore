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
        public BindingList<DTO.Customer> Customers { get => customers; set => customers = value; }

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

        public int SumBalance(DateTime date, int customerId)
        {
            int debt = Bill.Instance.Bills.Where(bill =>
                bill.CustomerId == customerId
                && bill.CreateDate.Month == date.Month
                && bill.CreateDate.Year == date.Year
            ).Sum(b => b.Balance);

            int payment = CashReceipt.Instance.Receipts.Where(receipt =>
                receipt.CreateDate.Month == date.Month
                && receipt.CreateDate.Year == date.Year
                && receipt.CustomerId == customerId
            ).Sum(rec => rec.Payment);

            return debt - payment;
        }

        private void CreateNewReport(DateTime date, int customerId)
        {
            var temp = BUS.DebtReport.Instance.Reports.FirstOrDefault(report =>
            {
                int m = date.Month - 1;
                int y = date.Year;

                if (m == 0)
                {
                    m = 12;
                    y--;
                }

                return report.Month == m && report.Year == y;
            });

            int start = temp == null ? 0 : temp.DebtFinal;
            int change = SumBalance(date, customerId);

            BUS.DebtReport.Instance.AddReport
            (
                date.Month,
                date.Year,
                customerId,
                start,
                change,
                start + change
            );
        }

        public void UpdateDebt(int type, int customerId, DateTime date, int amount, int oldAmount = 0)
        {
            var customer = Customers.First(cus => cus.Id == customerId);
            int old = customer.Debt;

            switch (type)
            {
                //Xóa
                case 1:
                    customer.Debt -= amount;
                    break;
                //Sửa hoá đơn
                case 2:
                    customer.Debt += (amount - oldAmount);
                    break;
                //Thêm
                case 3:
                    customer.Debt += amount;
                    break;
                //Sửa thu tiền
                case 4:
                    customer.Debt += (oldAmount - amount);
                    break;
            }

            UpdateCustomer(customer);

            if (!DebtReport.Instance.Reports.Any(report => 
                report.Month == date.Month 
                && report.Year == date.Year
                && report.CustomerId == customer.Id))
            {
                CreateNewReport(date, customerId);
            }
            else
            {
                DebtReport.Instance.UpdateChange(customerId, date, customer.Debt, old);
            }
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
