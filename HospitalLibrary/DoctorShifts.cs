using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace HospitalLibrary
{
     public class DoctorShifts
    {
        private TimeSpan tFrom;
        private int iDoctorShiftsId;
        //private TimeSpan tTo;

        public TimeSpan from
        {
            get
            {
                return tFrom;
            }
            set
            {
                tFrom = value;
            }
        }
        public int doctorShiftsId
        {
            get
            {
                return iDoctorShiftsId;
            }
            set
            {
                iDoctorShiftsId = value;
            }
        }

    }
    public class DoctorShiftsManager
    {
        public static List<DoctorShifts> getDoctorShifts()
        {
            List<DoctorShifts> doctorShiftsList = new List<DoctorShifts>();
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shifts_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    DoctorShifts ds = new DoctorShifts();
                    ds.doctorShiftsId = Int32.Parse(dt.Rows[i]["shiftsId"].ToString());
                    ds.from =(TimeSpan) dt.Rows[i]["from"];
                    doctorShiftsList.Add(ds);
                }
                return doctorShiftsList;
            }
        }
        
    }

}
