using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Author: PropertyChangedBase
    {
        private int titleId;
        private string name;

        public Author(int titleId, string name)
        {
            this.TitleId = titleId;
            this.Name = name;
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