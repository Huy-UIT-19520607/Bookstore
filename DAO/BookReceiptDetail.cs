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
        public static BindingList<DTO.BookReceiptDetail> Details { get => details; set => details = value; }

        private void GetListDetail()
        {
            string query = "select * from CT_PHIEUNHAPSACH";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in results.Rows)
            {
                Details.Add(new DTO.BookReceiptDetail(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    (int)row.ItemArray[2],
                    (int)row.ItemArray[3],
                    (int)row.ItemArray[4]
                ));
            }
        }

        public bool AddDetail(int bookId, int number, int receivePrice, int total)
        {
            return true;
        }
    }
}
