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
        private int iDoctorShiftId;
        private string sShiftName;
        private TimeSpan tFrom;
        private TimeSpan tTo;
        

        public int shiftId
        {
            get
            {
                return iDoctorShiftId;
            }
            set
            {
                iDoctorShiftId = value;
            }
        }
        public string shiftName
        {
            get
            {
                return sShiftName;
            }
            set
            {
                sShiftName = value;
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
                return sShiftName + " From " + tFrom + " To " + tTo;
            }
        }
        
    }
    public class DoctorShiftsManager
    {
        //gets doctorShifts list
        public static List<DoctorShiftsHL> getDoctorShifts()
        {
            List<DoctorShiftsHL> doctorShiftList = new List<DoctorShiftsHL>();
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
                    ds.shiftId = Int32.Parse(dt.Rows[i]["shiftId"].ToString());
                    ds.shiftName = dt.Rows[i]["shiftName"].ToString();
                    ds.from =(TimeSpan) dt.Rows[i]["from"];
                    ds.to = (TimeSpan)dt.Rows[i]["to"];
                    doctorShiftList.Add(ds);
                }
                return doctorShiftList;
            }
        }
        //saves doctor shift
        public static void doctorShiftSave(DoctorShiftsHL docshi)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shift_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Shift Name
                SqlParameter sShiftsName = new SqlParameter("@shiftName",docshi.shiftName);
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
        public static void doctorShiftUpdate(DoctorShiftsHL docshi)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shift_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //ShifId Integer param
                SqlParameter iShiftId = new SqlParameter("@shiftId", docshi.shiftId);
                iShiftId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iShiftId);

                //shiftName NVarChar param
                SqlParameter sShiftName = new SqlParameter("@shiftName", docshi.shiftName);
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
        public static void doctorShiftDelete(DoctorShiftsHL docshi)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Shift_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iShiftId = new SqlParameter("@shiftId", docshi.shiftId);
                iShiftId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iShiftId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
