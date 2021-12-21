using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Account
    {
        private static Account instance;

        //private static BindingList<DTO.Account> accounts;

        public static Account Instance {
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

        //public BindingList<DTO.Account> Accounts { get => accounts; set => accounts = value; }

        private Account()
        {
            //accounts = new BindingList<DTO.Account>();
            //GetListAccount();
        }

        public BindingList<DTO.Account> GetListAccount()
        {
            string query = "select TenDangNhap" +
                ", MatKhau" +
                ", TenHienThi" +
                ", PhanQuyen" + " from TAIKHOAN";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            string username;
            string displayname;
            string password;
            int permission;

            BindingList<DTO.Account> accounts = new BindingList<DTO.Account>();

            foreach (DataRow row in results.Rows)
            {
                username = row.ItemArray[0].ToString();
                password = row.ItemArray[1].ToString();
                displayname = row.ItemArray[2].ToString();
                permission = (int) row.ItemArray[3];

                accounts.Add(new DTO.Account(
                    username,
                    displayname,
                    password,
                    permission
                ));

                //Accounts.Add(account);
            }

            return accounts;
        }

        public bool Login(string username, string password)
        {
            string query = "EXEC sp_login @username , @password";
            DataTable results = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return results.Rows.Count > 0;
        }

        public bool AddAccount(DTO.Account newAcc)
        {
            string query = "EXEC sp_add_account @username , @displayname , @password , @permission";
            int results = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] {
                    newAcc.Username,
                    newAcc.DisplayName,
                    newAcc.Password,
                    newAcc.Permission
                });

            //if (results > 0)
            //{
            //    Accounts.Add(newAcc);
            //}    

            return results > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = "EXEC sp_remove_account @username";
            int results = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] {
                    username,
                });

            //if (results > 0)
            //{
            //    Accounts.Remove(Accounts.First(account => account.Username.Equals(username)));
            //}

            return results > 0;
        }

        public bool UpdateAccount(DTO.Account updated)
        {
            string query = "EXEC sp_update_account @username , @displayname , @password , @permission";
            int results = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] {
                    updated.Username,
                    updated.DisplayName,
                    updated.Password,
                    updated.Permission
                });

            //if (results > 0)
            //{
            //    var obj = Accounts.First(account => account.Username.Equals(updated.Username));

            //    obj.DisplayName = updated.DisplayName;
            //    obj.Password = updated.Password;
            //    obj.Permission = updated.Permission;
            //}

            return results > 0;
        }
    }
}
