using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class BookReceiptDetail: PropertyChangedBase
    {
        private int id;
        private int bookId;
        private int number;
        private int receivePrice;
        private int total;

        public BookReceiptDetail(int id, int bookId, int number, int receivePrice, int total)
        {
            this.Id = id;
            this.BookId = bookId;
            this.Number = number;
            this.ReceivePrice = receivePrice;
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
        public int ReceivePrice 
        { 
            get => receivePrice; 
            set
            {
                receivePrice = value;
                OnPropertyChanged("ReceivePrice");
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
