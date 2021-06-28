using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class BookReceipt
    {
        private static BookReceipt instance;

        public BookReceipt()
        {

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

        public BindingList<DTO.BookReceipt> GetListReceipt()
        {
            string query = "select * from PHIEUNHAPSACH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.BookReceipt> bookReceipts = new BindingList<DTO.BookReceipt>();

            foreach (DataRow row in result.Rows)
            {
                bookReceipts.Add(new DTO.BookReceipt(
                    (int)row.ItemArray[0],
                    DateTime.Parse(row.ItemArray[1].ToString()),
                    (int)row.ItemArray[2]
                ));
            }

            return bookReceipts;
        }

        public int AddReceipt(DateTime date, int total)
        {
            string query = "exec sp_add_book_receipt @data , @total";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[]
            {
                date.ToString("s"),
                total
            });

            if (result == null)
            {
                return -1;
            }

            return (int)result;
        }

        public bool UpdateReceipt(int id, DateTime date)
        {
            string query = "exec sp_update_book_receipt @id , @date";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id,
                date.ToString("s")
            });

            return result > 0;
        }

        public bool DeleteReceipt(int id)
        {
            string query = "exec sp_remove_book_receipt @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id
            });

            return result > 0;
        }
    }
}
