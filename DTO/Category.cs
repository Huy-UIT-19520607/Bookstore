using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Category: PropertyChangedBase
    {
        private int id;
        private string name;

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
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
    }
}
