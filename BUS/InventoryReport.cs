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

        public static InventoryReport Instance { get => instance; set => instance = value; }
        public static BindingList<DTO.InventoryReport> Reports { get => reports; set => reports = value; }
    
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
    }
}
