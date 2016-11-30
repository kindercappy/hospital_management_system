using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalLibrary
{
    public class Users
    {
        private string sUserName;
        private string sPassword;
        private Guid gUserGuide = Guid.NewGuid();

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
        public Guid userGuide
        {
            get
            {
                return gUserGuide;
            }
            set
            {
                gUserGuide = value;
            }
        }

    }
    public class UsersManager
    {
        public static void userInsert(Users user)
        {
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

                SqlParameter gUserGuide = new SqlParameter("@userGuid", user.userGuide);
                gUserGuide.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                cmd.Parameters.Add(gUserGuide);

                cmd.ExecuteNonQuery();
            }
        }

        public static int getUserByIdUserNameAndPassword(string userName, string password)
        {
            int userId = 0;
            //using(SqlCommand cmd = new SqlCommand())
            //{
            //    cmd.Connection = Common.getConnection();
            //    cmd.CommandText = "User_Select_By_UserName";
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //    SqlParameter sUserName = new SqlParameter("@userName", userName);
            //    sUserName.SqlDbType = System.Data.SqlDbType.NVarChar;
            //    cmd.Parameters.Add(sUserName);

            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        int dbUserId = Convert.ToInt32(dr["userId"]);
            //        string dbPassword = Convert.ToString(dr["password"]);
            //        string dbUserGuid = Convert.ToString(dr["userGuid"]);
            //        string dbPasswordPlusGuid = dbPassword + dbUserGuid;

            //        string hashedPassword = Security.HashSHA1(dbPassword + dbUserGuid);
            //        if(dbPasswordPlusGuid == hashedPassword)
            //        {
            //            userId = dbUserId;
            //        }
            //    }
            //    return userId;
            //}
            SqlConnection con = Common.getConnection();
            using(SqlCommand cmd = new SqlCommand("SELECT userId,password,userGuid FROM Users WHERE userName=@userName", con))
            {
                cmd.Parameters.AddWithValue("@userName", userName);
                //con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int dbUserId = Convert.ToInt32(dr["UserId"]);
                    string dbPassword = Convert.ToString(dr["Password"]);
                    string dbUserGuid = Convert.ToString(dr["UserGuid"]);
                        
                    string hashedPassword = Security.HashSHA1(password + dbUserGuid);

                    if(dbPassword == hashedPassword)
                    {
                        userId = dbUserId;
                    }
                    //con.Close();
                }
                return userId;
            }
        }
    }
}
