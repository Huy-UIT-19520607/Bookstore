using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class CashReceipt: PropertyChangedBase
    {
        private int id;
        private int customerId;
        private DateTime createDate;
        private int payment;

        public CashReceipt(int id, int customerId, DateTime createDate, int payment)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.CreateDate = createDate;
            this.Payment = payment;
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
        public int Payment 
        { 
            get => payment; 
            set
            {
                payment = value;
                OnPropertyChanged("Payment");
            }
        }
    }
}
