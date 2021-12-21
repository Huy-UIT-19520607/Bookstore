using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class InventoryReport
    {
        private static InventoryReport instance;
        private static BindingList<DTO.InventoryReport> reports;

        public InventoryReport()
        {
            Reports = new BindingList<DTO.InventoryReport>();
            GetListReport();
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
        public BindingList<DTO.InventoryReport> Reports { get => reports; set => reports = value; }
    
        public void GetListReport()
        {
            Reports = DAO.InventoryReport.Instance.GetListReport();
        }

        public bool AddReport(int month, int year, int bookId, int first, int change, int final)
        {
            if (DAO.InventoryReport.Instance.AddReport(month, year, bookId, first, change, final))
            {
                Reports.Add(new DTO.InventoryReport(
                    month,
                    year,
                    bookId,
                    first,
                    change,
                    final
                ));

                return true;
            }
            return false;
        }

        public void UpdateChange(int bookId, DateTime date, int amount, int oldAmount)
        {
            var report = Reports.FirstOrDefault
                (rpt => rpt.Month == date.Month && rpt.Year == date.Year && rpt.BookId == bookId);

            if (report != null)
            {
                report.Change += (amount - oldAmount);
                report.Final = report.First + report.Change;

                UpdateReport(report);
            }
        }

        public bool UpdateReport(DTO.InventoryReport updated)
        {
            if (DAO.InventoryReport.Instance.UpdateReport(updated))
            {
                var obj = Reports.First(report =>
                    report.Month == updated.Month
                    && report.Year == updated.Year
                    && report.BookId == updated.BookId);

                obj.First = updated.First;
                obj.Change = updated.Change;
                obj.Final = updated.Final;

                return true;
            }
            return false;
        }
    }
}
