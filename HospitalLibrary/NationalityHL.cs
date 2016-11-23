using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class NationalityHL
    {
        private string sNationalityName;
        private int sNationalityId;

        public string nationalityName
        {
            get
            {
                return sNationalityName;
            }
            set
            {
                sNationalityName = value;
            }
        }
        public int nationalityId
        {
            get
            {
                return sNationalityId;
            }
            set
            {
                sNationalityId = value;
            }
        }
    }

        public class NationalityManager
        {
            public static List<NationalityHL> getNationalityList()
            {
                List<NationalityHL> NationalityList = new List<NationalityHL>();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Nationality_Select";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        NationalityHL nation = new NationalityHL();
                        nation.nationalityName = dt.Rows[i]["nationality"].ToString();
                        nation.nationalityId = Int32.Parse(dt.Rows[i]["nationalityId"].ToString());
                        NationalityList.Add(nation);
                    }
                }

                return NationalityList;
            }

            public static DataTable getNationalities()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Nationality_Select";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
            
        public static void nationalityUpdate(NationalityHL nation)
        {
            using (SqlCommand cmd = new SqlCommand())
            {


                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Nationality_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sNationalityName = new SqlParameter("@nationality", nation.nationalityName);
                sNationalityName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sNationalityName);

                SqlParameter iNationalityId = new SqlParameter("@nationalityId", nation.nationalityId);
                iNationalityId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationalityId);

                cmd.ExecuteNonQuery();
            }


        }

        public static void nationalityInsert(NationalityHL nation)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Nationality_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sNationalityName = new SqlParameter("@nationalityName", nation.nationalityName);
                sNationalityName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sNationalityName);

                cmd.ExecuteNonQuery();
            }
        }

        public static void nationalityDelete(NationalityHL nation)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Nationality_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iNationalityId = new SqlParameter("@nationalityId", nation.nationalityId);
                iNationalityId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationalityId);

                cmd.ExecuteNonQuery();
            }
        }

        }
    
}
