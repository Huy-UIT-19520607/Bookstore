using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class CashReceipt
    {
        private static CashReceipt instance;
        private static BindingList<DTO.CashReceipt> cashReceipts;

        public CashReceipt()
        {
            cashReceipts = new BindingList<DTO.CashReceipt>();
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
        public static BindingList<DTO.CashReceipt> CashReceipts { get => cashReceipts; set => cashReceipts = value; }

        private void GetListReceipt()
        {
            string query = "select * form PHIEUTHUTIEN";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in results.Rows)
            {
                CashReceipts.Add(new DTO.CashReceipt(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    DateTime.Parse(row.ItemArray[2].ToString()),
                    (int)row.ItemArray[3]
                ));
            }
        }

        public bool AddReceipt(int customerId, DateTime date, int amount)
        {
            string query = "EXEC sp_add_cash_receipt @customer_id , @date , @amount";
            object results = DataProvider.Instance.ExecuteScalar(query, new object[]
            {
                customerId,
                date,
                amount
            });

            if (results != null)
            {
                CashReceipts.Add(new DTO.CashReceipt(
                    (int)results,
                    customerId,
                    date,
                    amount
                ));
            }

            return results != null;
        }

        public bool UpdateReceipt(DTO.CashReceipt updated)
        {
            string query = "EXEC sp_update_cash_receipt @id , @customer_id , @date , @amount";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Id,
                updated.CustomerId,
                updated.CreateDate,
                updated.Payment
            });

            if (results > 0)
            {
                var obj = CashReceipts.First(receipt => receipt.Id == updated.Id);

                obj.CustomerId = updated.CustomerId;
                obj.CreateDate = updated.CreateDate;
                obj.Payment = updated.Payment;
            }

            return results > 0;
        }

        public bool DeleteReceipt(int id)
        {
            string query = "EXEC sp_remove_cash_receipt @id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id
            });

            if (results > 0)
            {
                CashReceipts.Remove(CashReceipts.First(receipt => receipt.Id == id));
            }

            return results > 0;
        }
    }
}
