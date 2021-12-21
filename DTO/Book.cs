using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Book: PropertyChangedBase
    {
        private int id;
        private int titleId;
        private string publisher;
        private int publishYear;
        private int inStock;
        private int price;

        public Book(int id, int titleId, string publisher, int publishYear, int inStock, int price)
        {
            this.Id = id;
            this.TitleId = titleId;
            this.Publisher = publisher;
            this.PublishYear = publishYear;
            this.InStock = inStock;
            this.Price = price;
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
        public int TitleId 
        { 
            get => titleId;
            set 
            {
                titleId = value;
                OnPropertyChanged("TitleId");
            }
        }
        public string Publisher 
        { 
            get => publisher; 
            set
            {
                publisher = value;
                OnPropertyChanged("Publisher");
            }
        }
        public int PublishYear
        { 
            get => publishYear; 
            set
            {
                publishYear = value;
                OnPropertyChanged("PublishYear");
            }
        }
        public int InStock 
        { 
            get => inStock;
            set
            {
                inStock = value;
                OnPropertyChanged("InStock");
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
    }
}
