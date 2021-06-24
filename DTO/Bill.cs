using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Bill: PropertyChangedBase
    {
        private int id;
        private int customerId;
        private DateTime createDate;
        private int totalPrice;
        private int payment;
        private int balance;

        public Bill(int id, int customerId, DateTime createDate, int totalPrice, int payment, int balance)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.CreateDate = createDate;
            this.TotalPrice = totalPrice;
            this.Payment = payment;
            this.Balance = balance;
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
        public int CustomerId 
        { 
            get => customerId;
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerId");
            }
        }
        public DateTime CreateDate
        { 
            get => createDate; 
            set
            {
                createDate = value;
                OnPropertyChanged("CreateDate");
            } 
        }
        public int TotalPrice
        {
            get => totalPrice; 
            set 
            {
                totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }         }
        public int Payment 
        { 
            get => payment; 
            set
            {
                payment = value;
                OnPropertyChanged("Payment");
            } 
        }
        public int Balance 
        { 
            get => balance; 
            set
            {
                balance = value;
                OnPropertyChanged("Balance");
            } 
        }
    }
}
