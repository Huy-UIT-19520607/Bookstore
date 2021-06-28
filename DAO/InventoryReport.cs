using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class InventoryReport
    {
        private static InventoryReport instance;
        //private static BindingList<DTO.InventoryReport> inventoryReports;

        public InventoryReport()
        {
            //inventoryReports = new BindingList<DTO.InventoryReport>();
            //GetListReport();
        }

        public static InventoryReport Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new InventoryReport();
                }
                return instance;
            }
            set => instance = value; 
        }
        //public static BindingList<DTO.InventoryReport> InventoryReports { get => inventoryReports; set => inventoryReports = value; }

        public BindingList<DTO.InventoryReport> GetListReport()
        {
            string query = "select * from BAOCAOTON";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.InventoryReport> inventoryReports = new BindingList<DTO.InventoryReport>();

            foreach (DataRow row in results.Rows)
            {
                //InventoryReports.Add(new DTO.InventoryReport(
                //    (int)row.ItemArray[0],
                //    (int)row.ItemArray[1],
                //    (int)row.ItemArray[2],
                //    (int)row.ItemArray[3],
                //    (int)row.ItemArray[4],
                //    (int)row.ItemArray[5]
                //));

                inventoryReports.Add(new DTO.InventoryReport(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    (int)row.ItemArray[2],
                    (int)row.ItemArray[3],
                    (int)row.ItemArray[4],
                    (int)row.ItemArray[5]
                ));
            }

            return inventoryReports;
        }

        public bool AddReport(int month, int year, int bookId, int first, int change, int final)
        {
            string query = "EXEC sp_add_inventory_report @month , @year , @book_id , @first , @change , @final";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                month,
                year,
                bookId,
                first,
                change,
                final
            });

            if (results > 0)
            {
                //InventoryReports.Add(new DTO.InventoryReport(
                //    month,
                //    year,
                //    bookId,
                //    first,
                //    change,
                //    final
                //));
            }

            return results > 0;
        }

        public bool UpdateReport(DTO.InventoryReport updated)
        {
            string query = "EXEC sp_update_inventory_report @month , @year , @book_id , @first , @change , @final";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Month,
                updated.Year,
                updated.BookId,
                updated.DeftStart,
                updated.Change,
                updated.DebtFinal
            });

            if (results > 0)
            {
                //var obj = InventoryReports.First(report => 
                //    report.Month == updated.Month 
                //    && report.Year == updated.Year
                //    && report.BookId == updated.BookId
                //);

                //obj.DeftStart = updated.DeftStart;
                //obj.Change = updated.Change;
                //obj.DebtFinal = updated.DebtFinal;
            }

            return results > 0;
        }

        public bool DeleteReport(int month, int year, int bookId)
        {
            string query = "EXEC sp_remove_inventory_report @month , @year , @book_id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                month,
                year,
                bookId
            });

            if (results > 0)
            {
                //InventoryReports.Remove(InventoryReports.First(report =>
                //    report.Month == month
                //    && report.Year == year
                //    && report.BookId == bookId
                //));
            }

            return results > 0;
        }
    }
}
