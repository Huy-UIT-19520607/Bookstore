using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class BookReceiptDetail
    {
        private static BookReceiptDetail instance;
        //private static BindingList<DTO.BookReceiptDetail> details;

        public BookReceiptDetail()
        {
            //Details = new BindingList<DTO.BookReceiptDetail>();
            //GetListDetail();
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
        //public static BindingList<DTO.BookReceiptDetail> Details { get => details; set => details = value; }

        public BindingList<DTO.BookReceiptDetail> GetListDetail()
        {
            string query = "select * from CT_PHIEUNHAPSACH";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.BookReceiptDetail> details = new BindingList<DTO.BookReceiptDetail>();

            foreach (DataRow row in results.Rows)
            {
                //Details.Add(new DTO.BookReceiptDetail(
                //    (int)row.ItemArray[0],
                //    (int)row.ItemArray[1],
                //    (int)row.ItemArray[2],
                //    (int)row.ItemArray[3],
                //    (int)row.ItemArray[4]
                //));

                details.Add(new DTO.BookReceiptDetail(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    (int)row.ItemArray[2],
                    (int)row.ItemArray[3],
                    (int)row.ItemArray[4]
                ));
            }

            return details;
        }

        public bool AddDetail(int id, int bookId, int number, int receivePrice, int total)
        {
            string query =
                "exec sp_add_book_receipt_detail @id , @book_id , @number , @receive_price , @total";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id,
                bookId,
                number,
                receivePrice,
                total
            });

            if (result > 0)
            {
                //Details.Add(new DTO.BookReceiptDetail(
                //    (int)result,
                //    bookId,
                //    number,
                //    receivePrice,
                //    total
                //));

                // return -1;
            }

            return result > 0;
        }

        public bool UpdateDetail(DTO.BookReceiptDetail updated)
        {
            string query =
                "exec sp_update_book_receipt_detail @id , @book_id , @number , @receive_price , @total";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Id,
                updated.BookId,
                updated.Number,
                updated.ReceivePrice,
                updated.Total
            });

            if (result > 1)
            {
                //var obj = Details.First(detail => detail.Id == updated.Id && detail.BookId == updated.BookId);

                //obj.Number = updated.Number;
                //obj.ReceivePrice = updated.ReceivePrice;
                //obj.Total = updated.Total;
            }

            return result > 1;
        }

        public bool DeleteDetail(int id, int bookId)
        {
            string query = "exec sp_remove_book_receipt_detail @id , @book_id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id,
                bookId
            });

            return result > 0;
        }
    }
}
