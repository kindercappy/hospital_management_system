using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalLibrary
{
    public class Doctor
    {
        private string sFirstName;
        

        public string firstName
        {
            get
            {
                return sFirstName;
            }
            set
            {
                sFirstName = value;
            }
        }
        
    }

    public class DoctorManager
    {
        public static void Doctor_Save(Doctor doc)
        {

            //method to save in sample Doctor table in SqlServer
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Insert_Sample";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter sFirstNameParam = new SqlParameter("@firstName", doc.firstName);
                sFirstNameParam.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstNameParam);
                cmd.ExecuteNonQuery();
            }

        }
        
        

    }


}


