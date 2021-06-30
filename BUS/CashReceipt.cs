using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class CashReceipt
    {
        private static CashReceipt instance;
        private static BindingList<DTO.CashReceipt> receipts;

        public CashReceipt()
        {
            Receipts = new BindingList<DTO.CashReceipt>();
            GetListReceipt();
        }

        public static CashReceipt Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new CashReceipt();
                }
                return instance;
            } 
            set => instance = value; 
        }
        public BindingList<DTO.CashReceipt> Receipts { get => receipts; set => receipts = value; }
    
        public void GetListReceipt()
        {
            Receipts = DAO.CashReceipt.Instance.GetListReceipt();
        }

        public bool AddReceipt(int customerId, DateTime date, int amount)
        {
            int id = DAO.CashReceipt.Instance.AddReceipt(customerId, date, amount);

            if (id != -1)
            {
                Receipts.Add(new DTO.CashReceipt(
                    id,
                    customerId,
                    date.Date,
                    amount
                ));

                //var customer = Customer.Instance.Customers.First(cus => cus.Id == customerId);
                //customer.Debt -= amount;
                Customer.Instance.UpdateDebt(1, customerId, date, amount);

                return true;
            }
            return false;
        }

        public bool UpdateReceipt(DTO.CashReceipt updated)
        {
            var obj = Receipts.First(receipt => receipt.Id == updated.Id);

            if (DAO.CashReceipt.Instance.UpdateReceipt(updated))
            {
                //var customer = Customer.Instance.Customers.First(cus => cus.Id == updated.CustomerId);
                //customer.Debt += (obj.Payment - updated.Payment);
                Customer.Instance.UpdateDebt(4, updated.CustomerId, updated.CreateDate, updated.Payment, obj.Payment);

                obj.CustomerId = updated.CustomerId;
                obj.CreateDate = updated.CreateDate;
                obj.Payment = updated.Payment;

                return true;
            }
            return false;
        }

        public bool DeleteReceipt(int id)
        {
            if (DAO.CashReceipt.Instance.DeleteReceipt(id))
            {
                var obj = Receipts.First(receipt => receipt.Id == id);

                //var customer = Customer.Instance.Customers.First(cus => cus.Id == obj.CustomerId);
                //customer.Debt += obj.Payment;
                Customer.Instance.UpdateDebt(3, id, obj.CreateDate, obj.Payment);

                Receipts.Remove(obj);

                return true;
            }
            return false;
        }
    }
}
