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
        private int first;
        private int change;
        private int final;

        public InventoryReport(int month, int year, int bookId, int first, int change, int final)
        {
            this.Month = month;
            this.Year = year;
            this.BookId = bookId;
            this.First = first;
            this.Change = change;
            this.Final = final;
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
        public int First
        {
            get => first;
            set
            {
                first = value;
                OnPropertyChanged("First");
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
        public int Final
        {
            get => final;
            set
            {
                final = value;
                OnPropertyChanged("Final");
            }
        }
    }
}
