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
                    date,
                    amount
                ));

                return true;
            }
            return false;
        }

        public bool UpdateReceipt(DTO.CashReceipt updated)
        {
            if (DAO.CashReceipt.Instance.UpdateReceipt(updated))
            {
                var obj = Receipts.First(receipt => receipt.Id == updated.Id);

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
                Receipts.Remove(Receipts.First(receipt => receipt.Id == id));

                return true;
            }
            return false;
        }
    }
}
