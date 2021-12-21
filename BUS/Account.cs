using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class Account
    {
        private static Account instance;

        private static BindingList<DTO.Account> accounts;

        public static Account Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Account();
                }
                return instance;
            }
            private set => instance = value;
        }

        public BindingList<DTO.Account> Accounts { get => accounts; set => accounts = value; }

        private Account()
        {
            accounts = new BindingList<DTO.Account>();
            GetListAccount();
        }

        public void GetListAccount()
        {
            accounts = DAO.Account.Instance.GetListAccount();
        }

        public bool Login(string username, string password)
        {
            return DAO.Account.Instance.Login(username, password);
        }

        public bool AddAccount(DTO.Account newAcc)
        {
            //if (Accounts.FirstOrDefault(account => account.Username.Equals(username)) != null)
            //{
            //    DTO.Account newAcc = new DTO.Account(username, password, displayname, permission);

            //    if (DAO.Account.Instance.AddAccount(newAcc))
            //    {
            //        Accounts.Add(newAcc);
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //return false;
            //DTO.Account newAcc = new DTO.Account(username, password, displayname, permission);

            if (DAO.Account.Instance.AddAccount(newAcc))
            {
                Accounts.Add(newAcc);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteAccount(string username)
        {
            if (DAO.Account.Instance.DeleteAccount(username))
            {
                Accounts.Remove(Accounts.First(account => account.Username.Equals(username)));
                return true;
            }
            return false;
        }

        public bool UpdateAccount(DTO.Account updated)
        {
            if (DAO.Account.Instance.UpdateAccount(updated))
            {
                var obj = Accounts.First(account => account.Username.Equals(updated.Username));

                obj.DisplayName = updated.DisplayName;
                obj.Password = updated.Password;
                obj.Permission = updated.Permission;

                return true;
            }
            return false;
        }
    }
}
