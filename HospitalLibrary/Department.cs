﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
     public class Department
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

    public class DepartmentManager
        {
            public static List<Department> getDepartmentList()
            {
                List<Department> DepartmentList = new List<Department>();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Doctor_Department_Select";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Department dep = new Department();
                        dep.departmentName = dt.Rows[i]["DepartmentName"].ToString();
                        dep.departmentId =Int32.Parse(dt.Rows[i]["DepartmentID"].ToString());
                        DepartmentList.Add(dep);
                    }

                }
                return DepartmentList;
            }
        }
    
}
