using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace HospitalLibrary
{
     public class DoctorShiftsHL
    {
        private int iDoctorShiftsId;
        private string sShiftsName;
        private TimeSpan tFrom;
        private TimeSpan tTo;
        

        public int shiftsId
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
        public string shiftsName
        {
            get
            {
                return sShiftsName;
            }
            set
            {
                sShiftsName = value;
            }
        }
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
        public TimeSpan to
        {
            get
            {
                return tTo;
            }
            set
            {
                tTo = value;
            }
        }
        public string fullDetails
        {
            get
            {
                return sShiftsName + " From " + tFrom + " To " + tTo;
            }
        }
        
    }
    public class DoctorShiftsManager
    {
        //gets doctorShifts list
        public static List<DoctorShiftsHL> getDoctorShifts()
        {
            List<DoctorShiftsHL> doctorShiftsList = new List<DoctorShiftsHL>();
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shift_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    DoctorShiftsHL ds = new DoctorShiftsHL();
                    ds.shiftsId = Int32.Parse(dt.Rows[i]["shiftsId"].ToString());
                    ds.shiftsName = dt.Rows[i]["shiftsName"].ToString();
                    ds.from =(TimeSpan) dt.Rows[i]["from"];
                    ds.to = (TimeSpan)dt.Rows[i]["to"];
                    doctorShiftsList.Add(ds);
                }
                return doctorShiftsList;
            }
        }
        //saves doctor shift
        public static void doctorShiftsSave(DoctorShiftsHL docshi)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shift_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Shift Name
                SqlParameter sShiftsName = new SqlParameter("@shiftsName",docshi.shiftsName);
                sShiftsName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sShiftsName);

                //From
                SqlParameter tFrom = new SqlParameter("@from", docshi.from);
                tFrom.SqlDbType = System.Data.SqlDbType.Time;
                cmd.Parameters.Add(tFrom);

                //To
                SqlParameter tTo = new SqlParameter("@to", docshi.to);
                tTo.SqlDbType = System.Data.SqlDbType.Time;
                cmd.Parameters.Add(tTo);

                cmd.ExecuteNonQuery();
            
            }
        }
        //updates doctor shift
        public static void doctorShiftsUpdate(DoctorShiftsHL docshi)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shift_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //ShifId Integer param
                SqlParameter iShiftId = new SqlParameter("@shiftId", docshi.shiftsId);
                iShiftId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iShiftId);

                //shiftName NVarChar param
                SqlParameter sShiftName = new SqlParameter("@shiftName", docshi.shiftsName);
                sShiftName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sShiftName);

                //from Time(2) param
                SqlParameter tFrom = new SqlParameter("@from", docshi.from);
                tFrom.SqlDbType = System.Data.SqlDbType.Time;
                cmd.Parameters.Add(tFrom);

                //to Time(2) param
                SqlParameter tTo = new SqlParameter("@to", docshi.to);
                tTo.SqlDbType = System.Data.SqlDbType.Time;
                cmd.Parameters.Add(tTo);

                cmd.ExecuteNonQuery();
            }
        }
        //deletes doctor shift
        public static void doctorShiftsDelete(DoctorShiftsHL docshi)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shift_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iShiftId = new SqlParameter("@shiftId", docshi.shiftsId);
                iShiftId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iShiftId);

                cmd.ExecuteNonQuery();
            }
        }
    }

}
