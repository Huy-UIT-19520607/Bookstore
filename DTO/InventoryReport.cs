using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class InventoryReport: PropertyChangedBase
    {
        private int month;
        private int year;
        private int bookId;
        private int deftStart;
        private int change;
        private int debtFinal;

        public InventoryReport(int month, int year, int bookId, int deftStart, int change, int debtFinal)
        {
            this.Month = month;
            this.Year = year;
            this.BookId = bookId;
            this.DeftStart = deftStart;
            this.Change = change;
            this.DebtFinal = debtFinal;
        }

        public int Month
        {
            get => month;
            set
            {
                month = value;
                OnPropertyChanged("Month");
            }
        }
        public int Year
        {
            get => year;
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }
        public int BookId
        {
            get => bookId;
            set
            {
                bookId = value;
                OnPropertyChanged("BookId");
            }
        }
        public int DeftStart
        {
            get => deftStart;
            set
            {
                deftStart = value;
                OnPropertyChanged("DeftStart");
            }
        }
        public int Change
        {
            get => change;
            set
            {
                change = value;
                OnPropertyChanged("Change");
            }
        }
        public int DebtFinal
        {
            get => debtFinal;
            set
            {
                debtFinal = value;
                OnPropertyChanged("DebtFinal");
            }
        }
    }
}
