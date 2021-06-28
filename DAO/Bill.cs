using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Bill
    {
        private static Bill instance;
        //private static BindingList<DTO.Bill> bills;

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
        //public static BindingList<DTO.Bill> Bills { get => bills; set => bills = value; }

        public Bill()
        {
            //GetListBill();
        }

        public BindingList<DTO.Bill> GetListBill()
        {
            string query = "select * from HOADON";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.Bill> bills = new BindingList<DTO.Bill>();

            foreach (DataRow row in results.Rows)
            {
                //Bills.Add(new DTO.Bill(
                //    (int)row.ItemArray[0],
                //    (int)row.ItemArray[1],
                //    DateTime.Parse(row.ItemArray[2].ToString()),
                //    (int)row.ItemArray[3],
                //    (int)row.ItemArray[4],
                //    (int)row.ItemArray[5]
                //));

                bills.Add(new DTO.Bill(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    DateTime.Parse(row.ItemArray[2].ToString()),
                    (int)row.ItemArray[3],
                    (int)row.ItemArray[4],
                    (int)row.ItemArray[5]
                ));
            }

            return bills;
        }

        public int AddBill(int customerId, DateTime createDate, int total, int payment, int balance)
        {
            string query = "EXEC sp_add_bill @customer_id , @date , @total , @payment , @balance";
            object results = DataProvider.Instance.ExecuteScalar(query, new object[]
            {
                customerId,
                createDate.ToString("s"),
                total,
                payment,
                balance
            });

            if (results == null)
            {
                // bills.Add(new DTO.Bill(
                //    (int)results,
                //    customerId,
                //    createDate,
                //    total,
                //    payment,
                //    balance
                //));

                return -1;
            }

            return (int)results;
        }

        public bool DeleteBill(int id)
        {
            string query = "EXEC sp_remove_bill @id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            if (results > 0)
            {
                //Bills.Remove(Bills.First(bill => bill.Id == id));
            }

            return results > 0;
        }

        public bool UpdateBill(DTO.Bill updated)
        {
            string query = "EXEC sp_update_bill @id , @customer_id , @date , @total , @payment , @balance";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Id,
                updated.CustomerId,
                updated.CreateDate,
                updated.TotalPrice,
                updated.Payment,
                updated.Balance
            });

            if (results > 0)
            {
                //var obj = Bills.First(bill => bill.Id == updated.Id);

                //obj.CustomerId = updated.CustomerId;
                //obj.CreateDate = updated.CreateDate;
                //obj.TotalPrice = updated.TotalPrice;
                //obj.Payment = updated.Payment;
                //obj.Balance = updated.Balance;
            }

            return results > 0;
        }
    }
}
