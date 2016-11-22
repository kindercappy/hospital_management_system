using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class StaffShiftsHL
    {
        private int iStaffShiftId;
        private string sShiftName;
        private TimeSpan tFrom;
        private TimeSpan tTo;


        public int shiftId
        {
            get
            {
                return iStaffShiftId;
            }
            set
            {
                iStaffShiftId = value;
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
    public class StaffShiftsManager
    {
        //gets staffShifts list
        public static List<StaffShiftsHL> getStaffShifts()
        {
            List<StaffShiftsHL> staffShiftsList = new List<StaffShiftsHL>();
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Shift_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    StaffShiftsHL ss = new StaffShiftsHL();
                    ss.shiftId = Int32.Parse(dt.Rows[i]["shiftId"].ToString());
                    ss.shiftName = dt.Rows[i]["shiftName"].ToString();
                    ss.from = (TimeSpan)dt.Rows[i]["from"];
                    ss.to = (TimeSpan)dt.Rows[i]["to"];
                    staffShiftsList.Add(ss);
                }
            }
            return staffShiftsList;
        }
        //saves doctor shift
        public static void staffShiftSave(StaffShiftsHL staffShi)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Shift_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Shift Name
                SqlParameter sShiftName = new SqlParameter("@shiftName", staffShi.shiftName);
                sShiftName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sShiftName);

                //From
                SqlParameter tFrom = new SqlParameter("@from", staffShi.from);
                tFrom.SqlDbType = System.Data.SqlDbType.Time;
                cmd.Parameters.Add(tFrom);

                //To
                SqlParameter tTo = new SqlParameter("@to", staffShi.to);
                tTo.SqlDbType = System.Data.SqlDbType.Time;
                cmd.Parameters.Add(tTo);

                cmd.ExecuteNonQuery();
            }
        }
        //updates doctor shift

        //deletes doctor shift 
        public static DataTable getStaffShiftListByName(StaffShiftsHL staffShift)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Shift_Search_Name";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter sShiftName = new SqlParameter("@shiftName", staffShift.shiftName);
            sShiftName.SqlDbType = System.Data.SqlDbType.NVarChar;
            cmd.Parameters.Add(sShiftName);

            da.SelectCommand = cmd;
            da.Fill(dt);


            return dt;
        }
        public static DataTable getStaffShiftListById(StaffShiftsHL staffShift)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Shift_Search_Id";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter iStafShiftId = new SqlParameter();
            iStafShiftId.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(iStafShiftId);

            da.SelectCommand = cmd;
            da.Fill(dt);
            
                
            return dt;
        }
    }
}
