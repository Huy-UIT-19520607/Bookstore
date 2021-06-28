using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class BillDetail
    {
        private static BillDetail instance;

        public BillDetail()
        {
        }

        public static BillDetail Instance { get => instance; set => instance = value; }

        public BindingList<DTO.BillDetail> GetListDetail()
        {
            string query = "select * from CT_HOADON";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.BillDetail> details = new BindingList<DTO.BillDetail>();

            foreach(DataRow row in result.Rows)
            {
                details.Add(new DTO.BillDetail(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    (int)row.ItemArray[2],
                    (int)row.ItemArray[3],
                    (int)row.ItemArray[4]
                ));
            }

            return details;
        }

        public bool AddDetail(DTO.BillDetail billDetail)
        {
            string query = "exec sp_add_bill_detail @id , @book_id , @number , @price , @total";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                billDetail.Id,
                billDetail.BookId,
                billDetail.Number,
                billDetail.Price,
                billDetail.Total
            });

            return result > 0;
        }

        public bool UpdateDetail(DTO.BillDetail updated)
        {
            string query = "exec sp_update_bill_detail @id , @book_id , @number , @price , @total";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Id,
                updated.BookId,
                updated.Number,
                updated.Price,
                updated.Total
            });

            return result > 0;
        }

        public bool DeleteDetail(int id, int bookId)
        {
            string query = "exec sp_remove_bill_detail @id , @book_id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id,
                bookId
            });

            return result > 0;
        }
    }
}
