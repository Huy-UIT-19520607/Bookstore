//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BookStore.BUS
//{
//    public class Account
//    {
//        private static Account instance;

//        private static BindingList<DTO.Account> accounts = new BindingList<DTO.Account>();

//        public static Account Instance {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new Account();
//                }
//                return instance;
//            }
//            private set => instance = value; 
//        }

//        public BindingList<DTO.Account> Accounts { get => accounts; set => accounts = value; }

//        private Account()
//        {
            
//        }

//        public void GetListAccount()
//        {
            
//        }

//        public bool Login(string username, string password)
//        {
            
//        }

//        public bool AddAccount(DTO.Account newAcc)
//        {
            
//        }

//        public bool DeleteAccount(string username)
//        {
            
//        }

//        public bool UpdateAccount(DTO.Account updated)
//        {
            
//        }
//    }
//}
