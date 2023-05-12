using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNganHang
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {

            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @citizenID , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, CitizenID, Type FROM dbo.Account");
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool InsertAccount(string userName, string citizenID, int type, string password)
        {
            string query = string.Format("INSERT dbo.Account ( UserName,CitizenID, Type, password )VALUES  ( N'{0}', N'{1}', {2}, N'{3}')", userName, citizenID, type, password);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool CheckExistAccount(string cccd)
        {
            string query = string.Format("SELECT COUNT(*) FROM Account WHERE citizenID = '{0}'", cccd);
            int result = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return (result > 0);
        }


        public bool UpdateAccount(string name, string citizenID, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET CitizenID = N'{1}', Type = {2} WHERE UserName = N'{0}'", name, citizenID, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool KiemTraTrungTenDangNhap(string tenDangNhap)
        {
            string query = $"SELECT COUNT(*) FROM Account WHERE UserName = '{tenDangNhap}'";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));
            return count > 0;
        }


        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where CitizenID  = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("update account set password = N'1962026656160185351301320480154111117132155' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool AccountCitizenID(string name)
        {
            string query = string.Format("SELECT CitizenID  FROM dbo.Account Where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
