using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class Nationality
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
            public static List<Nationality> getNationalityList()
            {
                List<Nationality> NationalityList = new List<Nationality>();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Nationality_Select";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for(int i = 0; i <
                        dt.Rows.Count; i++)
                    {
                        Nationality nation = new Nationality();
                        nation.nationalityName = dt.Rows[i]["Nationality"].ToString();
                        nation.nationalityId = Int32.Parse(dt.Rows[i]["NationalityID"].ToString());
                        NationalityList.Add(nation);
                    }
                }

                return NationalityList;
            }
        }
    
}
