using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalLibrary
{
    public class Users
    {
        private int sUserId;
        private string sUserName;
        private string sPassword;
        

        public string userName
        {
            get
            {
                return sUserName;
            }
            set
            {
                sUserName = value;
            }
        }
        public string password
        {
            get
            {
                return sPassword;
            }
            set
            {
                sPassword = value;
            }
        }
        public int userId
        {
            get
            {
                return sUserId;
            }
            set
            {
                sUserId = value;
            }

        }


    }
    public class UsersManager
    {
        public static void userInsert(Users user)
        {
            Guid userGuid = System.Guid.NewGuid();
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "User_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sUserName = new SqlParameter("@userName", user.userName);
                sUserName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sUserName);

                SqlParameter sPassword = new SqlParameter("@password", Security.HashSHA1(user.password));
                sPassword.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sPassword);

                SqlParameter gUserGuide = new SqlParameter("@userGuid", userGuid);
                gUserGuide.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                cmd.Parameters.Add(gUserGuide);

                SqlParameter sRealPassword = new SqlParameter("@realPassword", user.password);
                sRealPassword.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sRealPassword);

                cmd.ExecuteNonQuery();
            }
        }

        public static int getUserByIdUserNameAndPassword(Users user)
        {
            int userId = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "User_Select_By_UserName";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sUserName = new SqlParameter("@userName", user.userName);
                sUserName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sUserName);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int dbUserId = Convert.ToInt32(dr["userId"]);
                    string dbPassword = Convert.ToString(dr["password"]);
                    string dbUserGuid = Convert.ToString(dr["userGuid"]);

                    string hashedPassword = Security.HashSHA1(user.password) + dbUserGuid;
                    if (dbPassword + dbUserGuid == hashedPassword)
                    {
                        userId = dbUserId;
                    }
                }
                return userId;
            }
        }

        public static DataTable getUserIdByUserId(Users user)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "User_Select_By_Id";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter iUserId = new SqlParameter("@userId", user.userId);
            iUserId.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(iUserId);

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }

        public static void userUpdatePassword(Users user)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "User_Update_Password";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                
            }
        }
    }
}
