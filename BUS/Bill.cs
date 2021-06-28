using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class Bill
    {
        private static Bill instance;
        private static BindingList<DTO.Bill> bills;

        public Bill()
        {
            Bills = new BindingList<DTO.Bill>();
            GetListBill();
        }

        public static Bill Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new Bill();
                }
                return instance;
            }
            set => instance = value; 
        }
        public static BindingList<DTO.Bill> Bills { get => bills; set => bills = value; }

        public void GetListBill()
        {
            Bills = DAO.Bill.Instance.GetListBill();
        }

        public bool AddBill(int customerId, DateTime createDate, int total, int payment, int balance)
        {
            int id = DAO.Bill.Instance.AddBill(customerId, createDate, total, payment, balance);

            if (id != -1)
            {
                Bills.Add(new DTO.Bill(
                   id,
                   customerId,
                   createDate,
                   total,
                   payment,
                   balance
               ));

                return true;
            }
            return false;
        }

        public bool UpdateBill(DTO.Bill updated)
        {
            if (DAO.Bill.Instance.UpdateBill(updated))
            {
                var obj = Bills.First(bill => bill.Id == updated.Id);

                obj.CustomerId = updated.CustomerId;
                obj.CreateDate = updated.CreateDate;
                obj.TotalPrice = updated.TotalPrice;
                obj.Payment = updated.Payment;
                obj.Balance = updated.Balance;

                return true;
            }
            return false;
        }

        public bool DeleteBill(int id)
        {
            if (DAO.Bill.Instance.DeleteBill(id))
            {
                Bills.Remove(Bills.First(bill => bill.Id == id));

                BillDetail.Instance.DeleteAllDetailById(id);

                return true;
            }
            return false;
        }

        public void UpdateTotal(int id, int amount, int oldAmount)
        {
            var obj = Bills.First(bill => bill.Id == id);

            obj.TotalPrice += (amount - oldAmount);
        }

        public void DeleteAmount(int id, int amount)
        {
            var obj = Bills.First(bill => bill.Id == id);

            obj.TotalPrice -= amount;
        }
    }
}
