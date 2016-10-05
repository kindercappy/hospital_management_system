using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class DepartmentStaff
    {
        private string sDepartmentName;
        private int sDepartmentId;

        public string departmentName
        {
            get
            {
                return sDepartmentName;
            }
            set
            {
                sDepartmentName = value;
            }
        }
        public int departmentId
        {
            get
            {
                return sDepartmentId;
            }
            set
            {
                sDepartmentId = value;
            }
        }
    }

    public class DepartmentStaffManager
    {
        public static List<DepartmentStaff> getDepartmentList()
        {
            List<DepartmentStaff> DepartmentList = new List<DepartmentStaff>();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Department_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DepartmentStaff dep = new DepartmentStaff();
                    dep.departmentName = dt.Rows[i]["departmentName"].ToString();
                    dep.departmentId = Int32.Parse(dt.Rows[i]["departmentId"].ToString());
                    DepartmentList.Add(dep);
                }

            }
            return DepartmentList;
        }
    }
}
