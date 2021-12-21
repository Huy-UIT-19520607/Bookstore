using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Parameter: PropertyChangedBase
    {
        private string name;
        private int value;

        public Parameter(string name, int value)
        {
            this.Name = name;
            this.Value = value;
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
        public int Value
        { 
            get => value;
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }
    }
}
