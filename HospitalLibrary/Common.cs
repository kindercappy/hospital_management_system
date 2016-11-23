using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
     public class Common
    {
        
       public static string connectionString = "Data Source =CAPPY; Initial Catalog= hospitalManagementSystem; Integrated Security = SSPI; ";


        
    public static  SqlConnection getConnection()
    {
           
        SqlConnection cnn;
       
        cnn = new SqlConnection(connectionString);
        cnn.Open();

       return cnn;
    }
        public static bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool isValidTime(string time)
        {
            try
            {
                DateTime dtime;
                bool valid;

                return valid = DateTime.TryParseExact(time,
                                    "HHmmss",
                                    CultureInfo.InvariantCulture,
                                    DateTimeStyles.None,
                                    out dtime);

            }
            catch
            {
                return false;
            }
        }

    }

}

