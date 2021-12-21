using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class BillDetail: PropertyChangedBase
    {
        private int id;
        private int bookId;
        private int number;
        private int price;
        private int total;

        public BillDetail(int id, int bookId, int number, int price, int total)
        {
            this.Id = id;
            this.BookId = bookId;
            this.Number = number;
            this.Price = price;
            this.Total = total;
        }

        public int Id 
        { 
            get => id;
            set
            {
                id = value;
                OnPropertyChanged("Id");
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
        public int Number 
        { 
            get => number; 
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }
        public int Price 
        { 
            get => price; 
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public int Total 
        { 
            get => total; 
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
        }
    }
}
