using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Customer: PropertyChangedBase
    {
        private int id;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private int debt;

        public Customer(int id, string name, string address, string phoneNumber, string email, int debt)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Debt = debt;
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
        public string Name
        {
            get => name; 
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Address
        { 
            get => address;
            set 
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        public string PhoneNumber 
        { 
            get => phoneNumber; 
            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            } 
        }
        public string Email 
        {
            get => email; 
            set
            {
                email = value;
                OnPropertyChanged("Email");
            } 
        }
        public int Debt
        { 
            get => debt; 
            set
            {
                debt = value;
                OnPropertyChanged("Debt");
            } 
        }
    }
}
