using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class BookReceipt: PropertyChangedBase
    {
        private int id;
        private DateTime receiveDay;
        private int total;

        public BookReceipt(int id, DateTime receiveDay, int total)
        {
            this.Id = id;
            this.ReceiveDay = receiveDay;
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
        public DateTime ReceiveDay 
        { 
            get => receiveDay;
            set
            {
                receiveDay = value;
                OnPropertyChanged("ReceiveDay");
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
