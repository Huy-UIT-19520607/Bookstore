using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class BookReceipt
    {
        private static BookReceipt instance;
        private static BindingList<DTO.BookReceipt> receipts;

        public BookReceipt()
        {
            Receipts = new BindingList<DTO.BookReceipt>();
            GetListReceipt();
        }

        public static BookReceipt Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new BookReceipt();
                }
                return instance;
            }
            set => instance = value; 
        }
        public BindingList<DTO.BookReceipt> Receipts { get => receipts; set => receipts = value; }

        public void GetListReceipt()
        {
            Receipts = DAO.BookReceipt.Instance.GetListReceipt();
        }

        public bool AddReceipt(DateTime date, int total)
        {
            int id = DAO.BookReceipt.Instance.AddReceipt(date, total);

            if (id != -1)
            {
                Receipts.Add(new DTO.BookReceipt(
                    id,
                    date,
                    total
                ));

                return true;
            }
            return false;
        }

        public bool UpdateReceipt(int id, DateTime date)
        {
            if (DAO.BookReceipt.Instance.UpdateReceipt(id ,date))
            {
                var obj = Receipts.First(receipt => receipt.Id == id);

                obj.ReceiveDay = date;

                return true;
            }
            return false;
        }

        public bool DeleteReceipt(int id)
        {
            if (DAO.BookReceipt.Instance.DeleteReceipt(id))
            {
                var obj = Receipts.First(receipt => receipt.Id == id);
                Receipts.Remove(obj);

                BUS.BookReceiptDetail.Instance.DeleteAllDetailById(id, obj.ReceiveDay);

                return true;
            }
            return false;
        }

        public void UpdateTotal(int id, int amount, int oldAmount)
        {
            var obj = Receipts.First(receipt => receipt.Id == id);

            obj.Total += (amount - oldAmount);
        }

        public void DeleteAmount(int id, int amount)
        {
            var obj = Receipts.First(receipt => receipt.Id == id);

            obj.Total -= amount;
        }
    }
}
