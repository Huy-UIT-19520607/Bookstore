using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DTO
{
    public class Account: PropertyChangedBase
    {
        private string username;
        private string displayName;
        private string password;
        private int permission;

        public Account(string username, string displayName, string password, int permission)
        {
            this.Username = username;
            this.DisplayName = displayName;
            this.Password = password;
            this.Permission = permission;
        }

        public string Username 
        { 
            get => username; 
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }
        public string DisplayName 
        { 
            get => displayName;
            set
            {
                displayName = value;
                OnPropertyChanged("DisplayName");
            }
        }
        public string Password 
        { 
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public int Permission
        { 
            get => permission;
            set
            {
                permission = value;
                OnPropertyChanged("Permission");
            }
        }
    }
}
