using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Title: PropertyChangedBase
    {
        private int id;
        private string name;
        private string categoryId;

        public Title(int id, string name, string categoryId)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryId = categoryId;
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
        public string CategoryId 
        { 
            get => categoryId; 
            set 
            {
                categoryId = value;
                OnPropertyChanged("CategoryId");
            } 
        }
    }
}
