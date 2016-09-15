using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class Staff
    {
        private string sFirstName;
        private string sLastName;
        private int iDepartment;
        private int iAge;
        private string sSex;
        private int iHeightFt;
        private int iHeightInch;
        private int iWeight;
        private long iPhone;
        private string sEmail;
        private string sAddress;
        private int iNationality;

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

        public string lastName
        {
            get
            {
                return sLastName;
            }
            set
            {
                sLastName = value;
            }
        }

        public int department
        {
            get
            {
                return iDepartment;
            }
            set
            {
                iDepartment = value;
            }
        }

        public int age
        {
            get
            {
                return iAge;
            }
            set
            {
                iAge = value;
            }
        }

        public string sex
        {
            get
            {
                return sSex;
            }
            set
            {
                sSex = value;
            }
        }

        public int heightFt
        {
            get
            {
                return iHeightFt;
            }
            set
            {
                iHeightFt = value;
            }
        }

        public int heightInch
        {
            get
            {
                return iHeightInch;
            }
            set
            {
                iHeightInch = value;
            }
        }

        public int weight
        {
            get
            {
                return iWeight;
            }
            set
            {
                iWeight = value;
            }
        }

        public long phone
        {
            get
            {
                return iPhone;
            }
            set
            {
                iPhone = value;
            }
        }

        public string email
        {
            get
            {
                return sEmail;
            }
            set
            {
                sEmail = value;
            }
        }

        public string address
        {
            get
            {
                return sAddress;
            }
            set
            {
                sAddress = value;
            }
        }

        public int natioinality
        {
            get
            {
                return iNationality;
            }
            set
            {
                iNationality = value;
            }
        }
    }

    public class StaffManager
    {
        public static void Staff_Save(Staff staff)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //FirstName
                SqlParameter sFirstNameParam = new SqlParameter("@firstName", staff.firstName);
                sFirstNameParam.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstNameParam);
                //LastName
                SqlParameter sLastNameParam = new SqlParameter("@lastName", staff.lastName);
                sLastNameParam.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastNameParam);
                //Department
                SqlParameter iDepartmentParam = new SqlParameter("@department", staff.department);
                iDepartmentParam.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartmentParam);
                //Age
                SqlParameter iAge = new SqlParameter("@age", staff.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);
                //Sex
                SqlParameter sSex = new SqlParameter("@sex", staff.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);
                //HeightFt
                SqlParameter iHeightFt = new SqlParameter("@heightFt", staff.heightFt);
                iHeightFt.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightFt);
                //HeightInches
                SqlParameter iHeightInch = new SqlParameter("@heightInch", staff.heightInch);
                iHeightInch.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightInch);
                //Weight
                SqlParameter iWeight = new SqlParameter("@weight", staff.weight);
                iWeight.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iWeight);
                //Phone
                SqlParameter iPhone = new SqlParameter("@phone", staff.phone);
                iPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(iPhone);
                //Email
                SqlParameter sEmail = new SqlParameter("@email", staff.email);
                iPhone.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sEmail);
                //Address
                SqlParameter sAddress = new SqlParameter("@address", staff.address);
                sAddress.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sAddress);
                //Nationality
                SqlParameter iNationality = new SqlParameter("@nationalityId", staff.natioinality);
                iNationality.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationality);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

