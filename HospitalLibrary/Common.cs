using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

}



}

