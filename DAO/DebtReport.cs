using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class DebtReport
    {
        private static DebtReport instance;
        //private static BindingList<DTO.DebtReport> debtReports;

        public DebtReport()
        {
            //debtReports = new BindingList<DTO.DebtReport>();
            //GetListReport();
        }

        public static DebtReport Instance { get => instance; set => instance = value; }
        //public static BindingList<DTO.DebtReport> DebtReports { get => debtReports; set => debtReports = value; }

        public BindingList<DTO.DebtReport> GetListReport()
        {
            string query = "select * from BAOCAOCONGNO";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.DebtReport> debtReports = new BindingList<DTO.DebtReport>();

            foreach (DataRow row in results.Rows)
            {
                //DebtReports.Add(new DTO.DebtReport(
                //    (int)row.ItemArray[0],
                //    (int)row.ItemArray[1],
                //    (int)row.ItemArray[2],
                //    (int)row.ItemArray[3],
                //    (int)row.ItemArray[4],
                //    (int)row.ItemArray[5]
                //));

                debtReports.Add(new DTO.DebtReport(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    (int)row.ItemArray[2],
                    (int)row.ItemArray[3],
                    (int)row.ItemArray[4],
                    (int)row.ItemArray[5]
                ));
            }

            return debtReports;
        }

        public bool AddReport(int month, int year, int customerId, int first, int change, int final)
        {
            string query = "EXEC sp_add_debt_report @month , @year , @customer_id , @first , @change , @final";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                month,
                year,
                customerId,
                first,
                change,
                final
            });

            if (results > 0)
            {
                //DebtReports.Add(new DTO.DebtReport(
                //    month,
                //    year,
                //    customerId,
                //    first,
                //    change,
                //    final
                //));
            }

            return results > 0;
        }

        public bool UpdateReport(DTO.DebtReport updated)
        {
            string query = "EXEC sp_update_debt_report @month , @year , @customer_id , @first , @change , @final";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Month,
                updated.Year,
                updated.CustomerId,
                updated.DeftStart,
                updated.Change,
                updated.DebtFinal
            });

            if (results > 0)
            {
                //var obj = DebtReports.First(report =>
                //    report.Month == updated.Month
                //    && report.Year == updated.Year
                //    && report.CustomerId == updated.CustomerId
                //);

                //obj.DeftStart = updated.DeftStart;
                //obj.Change = updated.Change;
                //obj.DebtFinal = updated.DebtFinal;
            }

            return results > 0;
        }

        public bool DeleteReport(int month, int year, int customerId)
        {
            string query = "EXEC sp_remove_debt_report @month , @year , @customer_id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                month,
                year,
                customerId
            });

            if (results > 0)
            {
                //DebtReports.Remove(DebtReports.First(report =>
                //    report.Month == month
                //    && report.Year == year
                //    && report.CustomerId == customerId
                //));
            }

            return results > 0;
        }
    }
}