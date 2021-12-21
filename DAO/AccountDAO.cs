using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class AccountDAO
    {
        //private static AccountDAO instance;

        //private static BindingList<DTO.Account> accounts;

        //public static AccountDAO Instance {
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new AccountDAO();
        //        }
        //        return instance;
        //    }
        //    private set { instance = value; }
        //}

        //public BindingList<DTO.Account> Accounts { get => accounts; set => accounts = value; }

        //private AccountDAO()
        //{
        //    accounts = new BindingList<DTO.Account>();
        //    GetListAccount();
        //}

        //public void GetListAccount()
        //{
        //    string username;
        //    string displayname;
        //    string password;
        //    int permission;

        //    string query = "select TenDangNhap" +
        //        ", MatKhau" +
        //        ", TenHienThi" +
        //        ", PhanQuyen" + " from TAIKHOAN";
        //    DataTable results = DataProvider.Instance.ExecuteQuery(query);

        //    foreach (DataRow row in results.Rows)
        //    {
        //        username = row.ItemArray[0].ToString();
        //        password = row.ItemArray[1].ToString();
        //        displayname = row.ItemArray[2].ToString();
        //        permission = (int) row.ItemArray[3];

        //        DTO.Account account = new DTO.Account(
        //            username,
        //            displayname,
        //            password,
        //            permission
        //        );

        //        Accounts.Add(account);
        //    }
        //}

        //public bool Login(string username, string password)
        //{
        //    string query = "EXEC sp_login @username , @password";
        //    DataTable results = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

        //    return results.Rows.Count > 0;
        //}

        //public bool AddAccount(DTO.Account newAcc)
        //{
        //    string query = "EXEC sp_add_account @username , @displayname , @password , @permission";
        //    int results = DataProvider.Instance.ExecuteNonQuery(query,
        //        new object[] {
        //            newAcc.Username,
        //            newAcc.DisplayName,
        //            newAcc.Password,
        //            newAcc.Permission
        //        });

        //    if (results > 0)
        //    {
        //        Accounts.Add(newAcc);
        //    }    

        //    return results > 0;
        //}

        //public bool DeleteAccount(string username)
        //{
        //    string query = "EXEC sp_delete_account @username";
        //    int results = DataProvider.Instance.ExecuteNonQuery(query,
        //        new object[] {
        //            username,
        //        });

        //    if (results > 0)
        //    {
        //        Accounts.Remove(Accounts.First(account => account.Username.Equals(username)));
        //    }

        //    return results > 0;
        //}

        //public bool UpdateAccount(DTO.Account updated)
        //{
        //    string query = "EXEC sp_update_account @username , @displayname , @password , @permission";
        //    int results = DataProvider.Instance.ExecuteNonQuery(query,
        //        new object[] {
        //            updated.Username,
        //            updated.DisplayName,
        //            updated.Password,
        //            updated.Permission
        //        });

        //    if (results > 0)
        //    {
        //        var obj = Accounts.First(account => account.Username.Equals(updated.Username));

        //        obj.DisplayName = updated.DisplayName;
        //        obj.Password = updated.Password;
        //        obj.Permission = updated.Permission;
        //    }

        //    return results > 0;
        //}


        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set { instance = value; } 
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = @"SELECT * from TAIKHOAN where TenDangNhap = '" + username + "' and MatKhau = '" + password + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
