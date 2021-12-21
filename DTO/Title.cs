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
        private int categoryId;

        public Title(int id, string name, int categoryId)
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
        public int CategoryId 
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
