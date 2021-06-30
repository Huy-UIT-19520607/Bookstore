using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class BookReceiptDetail
    {
        private static BookReceiptDetail instance;
        private static BindingList<DTO.BookReceiptDetail> details;

        public BookReceiptDetail()
        {
            Details = new BindingList<DTO.BookReceiptDetail>();
            GetListDetail();
        }

        public static BookReceiptDetail Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookReceiptDetail();
                }
                return instance;
            }
            set => instance = value; 
        }
        public BindingList<DTO.BookReceiptDetail> Details { get => details; set => details = value; }

        public void GetListDetail()
        {
            Details = DAO.BookReceiptDetail.Instance.GetListDetail();
        }

        public bool AddDetail(int id, int bookId, int number, int receivePrice, int total)
        {
            if(DAO.BookReceiptDetail.Instance.AddDetail(id, bookId, number, receivePrice, total))
            {
                Details.Add(new DTO.BookReceiptDetail(
                    id,
                    bookId,
                    number,
                    receivePrice,
                    total
                ));

                //Book.Instance.UpdateInStock(1, bookId,
                //    BookReceipt.Instance.Receipts.First(receipt => receipt.Id == id).ReceiveDay,
                //    number);

                return true;
            }
            return false;
        }

        public bool DeleteDetail(int id, int bookId)
        {
            if (DAO.BookReceiptDetail.Instance.DeleteDetail(id, bookId))
            {
                var obj = Details.First(detail => detail.Id == id && detail.BookId == bookId);

                BookReceipt.Instance.DeleteAmount(id, obj.Total);

                Book.Instance.UpdateInStock(3, obj.BookId, 
                    BookReceipt.Instance.Receipts.First(receipt => receipt.Id == id).ReceiveDay,
                    obj.Number);

                Details.Remove(obj);

                return true;
            }
            return true;
        }

        public void DeleteAllDetailById(int id, DateTime date)
        {
            List<DTO.BookReceiptDetail> detailToRemove = Details.Where(detail => detail.Id == id).ToList();

            foreach (var detail in detailToRemove)
            {
                Details.Remove(detail);

                Book.Instance.UpdateInStock(3, detail.BookId, date, detail.Number);
            }
        }

        public bool UpdateDetail(DTO.BookReceiptDetail updated)
        {
            if (DAO.BookReceiptDetail.Instance.UpdateDetail(updated))
            {
                var obj = Details.First(detail => detail.Id == updated.Id && detail.BookId == updated.BookId);

                BookReceipt.Instance.UpdateTotal(updated.Id, updated.Total, obj.Total);

                Book.Instance.UpdateInStock(2, updated.BookId,
                    BookReceipt.Instance.Receipts.First(receipt => receipt.Id == updated.Id).ReceiveDay,
                    updated.Number, obj.Number);

                obj.Number = updated.Number;
                obj.ReceivePrice = updated.ReceivePrice;
                obj.Total = updated.Total;

                return true;
            }
            return false;
        }
    }
}
