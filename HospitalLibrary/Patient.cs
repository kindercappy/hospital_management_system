using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class Patient
    {
        private string sFirstName;
        private string sLastName;
        //private string sFullName;
        private int iPatientId;
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

        public string userInfo
        {
            get
            {
                return sFirstName + " " + sLastName + " | " + iPhone + " | " + sAddress;
            }

        }
        public int patientId
        {
            get
            {
                return iPatientId;
            }
            set
            {
                iPatientId = value;
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

    public class PatientManager
    {   
        //saves patient
        public static void Patient_Save(Patient patient)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //FirstName
                SqlParameter sFirstNameParam = new SqlParameter("@firstName", patient.firstName);
                sFirstNameParam.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstNameParam);
                //LastName
                SqlParameter sLastNameParam = new SqlParameter("@lastName", patient.lastName);
                sLastNameParam.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastNameParam);
                //Department
                SqlParameter iDepartmentParam = new SqlParameter("@department", patient.department);
                iDepartmentParam.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartmentParam);
                //Age
                SqlParameter iAge = new SqlParameter("@age", patient.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);
                //Sex
                SqlParameter sSex = new SqlParameter("@sex", patient.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);
                //HeightFt
                SqlParameter iHeightFt = new SqlParameter("@heightFt", patient.heightFt);
                iHeightFt.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightFt);
                //HeightInches
                SqlParameter iHeightInch = new SqlParameter("@heightInch", patient.heightInch);
                iHeightInch.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightInch);
                //Weight
                SqlParameter iWeight = new SqlParameter("@weight", patient.weight);
                iWeight.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iWeight);
                //Phone
                SqlParameter iPhone = new SqlParameter("@phone", patient.phone);
                iPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(iPhone);
                //Email
                SqlParameter sEmail = new SqlParameter("@email", patient.email);
                iPhone.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sEmail);
                //Address
                SqlParameter sAddress = new SqlParameter("@address", patient.address);
                sAddress.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sAddress);
                //Nationality
                SqlParameter iNationality = new SqlParameter("@nationalityId", patient.natioinality);
                iNationality.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationality);

                cmd.ExecuteNonQuery();
            }
        }
        //gets patient list
        public static List<Patient> getPatientList()
        {

            {
                List<Patient> patientList = new List<Patient>();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Common.getConnection();
                    cmd.CommandText = "Patient_Select_PId_Fn_Ln_Ph_Add";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Patient patient = new Patient();
                        patient.patientId = Int32.Parse(dt.Rows[i]["patientId"].ToString());
                        patient.firstName = dt.Rows[i]["firstName"].ToString();
                        patient.lastName = dt.Rows[i]["lastName"].ToString();
                        patient.phone = Int64.Parse(dt.Rows[i]["phone"].ToString());
                        patient.address = dt.Rows[i]["address"].ToString();
                        patientList.Add(patient);
                    }

                }
                return patientList;
            }

        }
        //updates patient
        public static void Patient_Update(Patient patient)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iPatientId = new SqlParameter("patientId", patient.patientId);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iPatientId);

                SqlParameter sFirstName = new SqlParameter("@firstName", patient.firstName);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);

                SqlParameter sLastName = new SqlParameter("@lastName", patient.lastName);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);

                SqlParameter iDepartment = new SqlParameter("@department", patient.department);
                iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartment);

                SqlParameter iAge = new SqlParameter("@age", patient.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);

                SqlParameter sSex = new SqlParameter("@sex", patient.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);

                SqlParameter iHeightFt = new SqlParameter("@heightFt", patient.heightFt);
                iHeightFt.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightFt);

                SqlParameter iHeightInch = new SqlParameter("@heightInch", patient.heightInch);
                iHeightInch.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightInch);

                SqlParameter iWeight = new SqlParameter("@weight", patient.weight);
                iWeight.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iWeight);

                SqlParameter biPhone = new SqlParameter("@phone", patient.phone);
                biPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(biPhone);

                SqlParameter sEmail = new SqlParameter("@email", patient.email);
                sEmail.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sEmail);

                SqlParameter sAddress = new SqlParameter("@address", patient.address);
                sAddress.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sAddress);

                SqlParameter iNationality = new SqlParameter("@nationalityId", patient.natioinality);
                iNationality.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationality);

                cmd.ExecuteNonQuery();
            }
        }
        public static Patient Patien_Select(int patientId)
        {
            Patient patient = new Patient();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_Existing_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iPatientId = new SqlParameter("@patientId", patientId);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iPatientId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (patientId > 0)
                {
                    patient.firstName = dt.Rows[0]["firstName"].ToString();
                }
                cmd.ExecuteNonQuery();
            }
            return patient;
        }
    }
}





