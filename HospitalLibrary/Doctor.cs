using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalLibrary
{
    public class Doctor
    {
        private int iDoctorId;
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

        public int doctorId
        {
            get
            {
                return iDoctorId;
            }
            set
            {
                iDoctorId = value;
            }
        }
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

    public class DoctorManager
    {
        //saves doctor
        public static void Doctor_Save(Doctor doc)
        {

            //method to save in sample Doctor table in SqlServer
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //FirstName
                SqlParameter sFirstNameParam = new SqlParameter("@firstName", doc.firstName);
                sFirstNameParam.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstNameParam);
                //LastName
                SqlParameter sLastNameParam = new SqlParameter("@lastName", doc.lastName);
                sLastNameParam.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastNameParam);
                //Department
                SqlParameter iDepartmentParam = new SqlParameter("@department", doc.department);
                iDepartmentParam.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartmentParam);
                //Age
                SqlParameter iAge = new SqlParameter("@age", doc.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);
                //Sex
                SqlParameter sSex = new SqlParameter("@sex", doc.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);
                //HeightFt
                SqlParameter iHeightFt = new SqlParameter("@heightFt", doc.heightFt);
                iHeightFt.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightFt);
                //HeightInches
                SqlParameter iHeightInch = new SqlParameter("@heightInch", doc.heightInch);
                iHeightInch.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightInch);
                //Weight
                SqlParameter iWeight = new SqlParameter("@weight", doc.weight);
                iWeight.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iWeight);
                //Phone
                SqlParameter iPhone = new SqlParameter("@phone", doc.phone);
                iPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(iPhone);
                //Email
                SqlParameter sEmail = new SqlParameter("@email", doc.email);
                iPhone.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sEmail);
                //Address
                SqlParameter sAddress = new SqlParameter("@address", doc.address);
                sAddress.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sAddress);
                //Nationality
                SqlParameter iNationality = new SqlParameter("@nationality", doc.natioinality);
                iNationality.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationality);

                cmd.ExecuteNonQuery();
            }

        }
        //updates doctor
        public static void Doctor_Update(Doctor doctor)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //DoctorId Integer Parameter
                SqlParameter iDoctorId = new SqlParameter("@doctorId", doctor.doctorId);
                iDoctorId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDoctorId);

                //FirstName NVarChar Parameter
                SqlParameter sFirstName = new SqlParameter("@firstName", doctor.firstName);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);

                //LastName NVarChar Parameter
                SqlParameter sLastName = new SqlParameter("@lastName", doctor.lastName);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);

                //Department Integer Parameter
                SqlParameter iDepartment = new SqlParameter("@department", doctor.department);
                iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartment);

                //Age Integer Parameter
                SqlParameter iAge = new SqlParameter("@age", doctor.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);

                //Sex NVarChar Parameter
                SqlParameter sSex = new SqlParameter("@sex", doctor.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);

                //HeightFt Integer Parameter
                SqlParameter iHeightFt = new SqlParameter("heightFt", doctor.heightFt);
                iHeightFt.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightFt);

                //HeightInch Integer Parameter
                SqlParameter iHeightInch = new SqlParameter("heightInch", doctor.heightInch);
                iHeightInch.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightInch);

                //Weight Integer Parameter
                SqlParameter iWeight = new SqlParameter("@weight", doctor.weight);
                iWeight.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iWeight);

                //Phone Integer Parameter
                SqlParameter iPhone = new SqlParameter("@phone", doctor.phone);
                iPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(iPhone);

                //Email NVarChar Parameter
                SqlParameter sEmail = new SqlParameter("@email", doctor.email);
                sEmail.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sEmail);

                //Address NVarChar Parameter
                SqlParameter sAddress = new SqlParameter("@address", doctor.address);
                sAddress.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sAddress);

                //Nationality Integer Parameter
                SqlParameter iNationalityId = new SqlParameter("@nationalityId", doctor.natioinality);
                iNationalityId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationalityId);

                cmd.ExecuteNonQuery();

            }
        }
        //selects doctor

        //deletes doctor
        public static void Patient_Delete(Doctor doctor)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Doctor_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iDoctorId = new SqlParameter("@doctorId", doctor.doctorId);
                iDoctorId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDoctorId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
