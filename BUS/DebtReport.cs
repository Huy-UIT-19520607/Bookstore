using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class DebtReport
    {
        private static DebtReport instance;
        private static BindingList<DTO.DebtReport> reports;

        public DebtReport()
        {
            Reports = new BindingList<DTO.DebtReport>();
            GetListReport();
        }

        public static DebtReport Instance { get => instance; set => instance = value; }
        public static BindingList<DTO.DebtReport> Reports { get => reports; set => reports = value; }

        public void GetListReport()
        {
            Reports = DAO.DebtReport.Instance.GetListReport();
        }

        public bool AddReport(int month, int year, int customerId, int first, int change, int final)
        {
            if (DAO.DebtReport.Instance.AddReport(month, year, customerId, first, change, final))
            {
                Reports.Add(new DTO.DebtReport(
                    month,
                    year,
                    customerId,
                    first,
                    change,
                    final
                ));

                return true;
            }

            return false;
        }

        //public bool UpdateReport(DTO.DebtReport updated)
        //{
        //    if (DAO.DebtReport.Instance.UpdateReport(updated))
        //    {
        //        var obj = Reports.First(report =>
        //            report.Month == updated.Month
        //            && report.Year == updated.Year
        //            && report.CustomerId == updated.CustomerId
        //        );

        //        obj.DeftStart = updated.DeftStart;
        //        obj.Change = updated.Change;
        //        obj.DebtFinal = updated.DebtFinal;

        //        return true;
        //    }
        //    return false;
        //}

        //public bool DeleteReport(int month, int year, int customerId)
        //{
        //    if (DAO.DebtReport.Instance.DeleteReport(month, year, customerId))
        //    {
        //        Reports.Remove(Reports.First(report =>
        //            report.Month == month
        //            && report.Year == year
        //            && report.CustomerId == customerId
        //        ));

        //        return true;
        //    }
        //    return false;
        //}
    }
}
