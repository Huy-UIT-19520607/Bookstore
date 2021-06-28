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
        public BindingList<DTO.Bill> Bills { get => bills; set => bills = value; }

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

                if (balance > 0)
                {
                    Customer.Instance.UpdateDebt(3, customerId, createDate, balance);
                }

                return true;
            }
            return false;
        }

        public bool UpdateBill(DTO.Bill updated)
        {
            if (DAO.Bill.Instance.UpdateBill(updated))
            {
                var obj = Bills.First(bill => bill.Id == updated.Id);

                if (updated.Balance > 0)
                {
                    Customer.Instance.UpdateDebt(2, updated.CustomerId, updated.CreateDate, updated.Balance, obj.Balance);
                }

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
                var obj = Bills.First(bill => bill.Id == id);

                if (obj.Balance > 0)
                {
                    Customer.Instance.UpdateDebt(1,  obj.CustomerId, obj.CreateDate, obj.Balance);
                }

                BillDetail.Instance.DeleteAllDetailById(id, obj.CreateDate);

                Bills.Remove(obj);

                return true;
            }
            return false;
        }

        public void UpdateTotal(int id, int amount, int oldAmount)
        {
            var obj = Bills.First(bill => bill.Id == id);

            obj.TotalPrice += (amount - oldAmount);

            UpdateBill(new DTO.Bill(
                id,
                obj.CustomerId,
                obj.CreateDate,
                obj.TotalPrice,
                obj.Payment,
                obj.TotalPrice - obj.Payment
            ));

            if (obj.TotalPrice - obj.Payment > 0)
            {
                Customer.Instance.UpdateDebt(2, obj.CustomerId, obj.CreateDate, obj.TotalPrice - obj.Payment, obj.Balance);
            }
        }

        public void DeleteAmount(int id, int amount)
        {
            var obj = Bills.First(bill => bill.Id == id);

            obj.TotalPrice -= amount;

            UpdateBill(new DTO.Bill(
                id,
                obj.CustomerId,
                obj.CreateDate,
                obj.TotalPrice,
                obj.Payment,
                obj.TotalPrice - obj.Payment
            ));

            if (obj.TotalPrice - obj.Payment > 0)
            {
                Customer.Instance.UpdateDebt(2, obj.CustomerId, obj.CreateDate, obj.TotalPrice - obj.Payment, obj.Balance);
            }
        }
    }
}
