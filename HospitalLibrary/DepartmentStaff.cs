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
        public static DataTable staffDepartmentSelect()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();       
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Department_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
            
        }
        public static void staffDepartmentInsert(DepartmentStaff depStaff)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Department_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sDepartmentName = new SqlParameter("@departmentName", depStaff.departmentName);
                sDepartmentName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sDepartmentName);

                cmd.ExecuteNonQuery();
            }
        }
        public static void staffDepartmentUpdate(DepartmentStaff depStaff)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Department_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sDepartmentName = new SqlParameter("@departmentName", depStaff.departmentName);
                sDepartmentName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sDepartmentName);

                SqlParameter iDepartmentId = new SqlParameter("@departmentId", depStaff.departmentId);
                iDepartmentId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartmentId);

                cmd.ExecuteNonQuery();

            }
        }
        public static void staffDepartmentDelete(DepartmentStaff depStaff)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Department_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iDepartmentId = new SqlParameter("@departmentId", depStaff.departmentId);
                iDepartmentId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartmentId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
