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
        private int iPatientId;
        //private int iDepartment;
        private int iAge;
        private string sSex;
        private int iHeightFt;
        private int iHeightInch;
        private decimal iWeight;
        private long iPhone;
        private string sEmail;
        private string sAddress;
        private int iNationality;
        private TimeSpan tFrom;
        private TimeSpan tTo;
        private DateTime dtEntryTime;

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

        //public int department
        //{
        //    get
        //    {
        //        return iDepartment;
        //    }
        //    set
        //    {
        //        iDepartment = value;
        //    }
        //}

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

        public decimal weight
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

        public DateTime entryTime
        {
            get
            {
                return dtEntryTime;
            }
            set
            {
                dtEntryTime = value;
            }
        }
    }

    public class PatientManager
    {   
        //saves patient
        public static void patientSave(Patient patient)
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
                //SqlParameter iDepartmentParam = new SqlParameter("@department", patient.department);
                //iDepartmentParam.SqlDbType = System.Data.SqlDbType.Int;
                //cmd.Parameters.Add(iDepartmentParam);
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
                iWeight.SqlDbType = System.Data.SqlDbType.Decimal;
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
        //save patient for appointment
        public static void patientAppSave(Patient patient)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_For_Appointment_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //firstName NVarChar param
                SqlParameter sFirstName = new SqlParameter("@firstName", patient.firstName);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);

                //lastName NVarChar param
                SqlParameter sLastName = new SqlParameter("@lastName", patient.lastName);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);

                //age Integer param
                SqlParameter iAge = new SqlParameter("@age", patient.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);

                //sex NVarChar param
                SqlParameter sSex = new SqlParameter("@sex", patient.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);

                //nationalityId Integer param
                SqlParameter iNationalityId = new SqlParameter("@nationalityId", patient.natioinality);
                iNationalityId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationalityId);

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
        public static void patientUpdate(Patient patient)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //PatientId Integer Parameter
                SqlParameter iPatientId = new SqlParameter("@patientId", patient.patientId);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iPatientId);

                //FirstName NVarChar Parameter
                SqlParameter sFirstName = new SqlParameter("@firstName", patient.firstName);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);

                //LastName NVarChar Parameter
                SqlParameter sLastName = new SqlParameter("@lastName", patient.lastName);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);

                ////Department Integer Parameter
                //SqlParameter iDepartment = new SqlParameter("@department", patient.department);
                //iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                //cmd.Parameters.Add(iDepartment);

                //Age Integer Parameter
                SqlParameter iAge = new SqlParameter("@age", patient.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);

                //Sex NVarChar Parameter
                SqlParameter sSex = new SqlParameter("@sex", patient.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);

                //HeightFt Integer Parameter
                SqlParameter iHeightFt = new SqlParameter("@heightFt", patient.heightFt);
                iHeightFt.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightFt);

                //HeightInch Integer Parameter
                SqlParameter iHeightInch = new SqlParameter("@heightInch", patient.heightInch);
                iHeightInch.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightInch);

                //Weight Integer Parameter
                SqlParameter iWeight = new SqlParameter("@weight", patient.weight);
                iWeight.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iWeight);

                //Phone Integer Parameter
                SqlParameter biPhone = new SqlParameter("@phone", patient.phone);
                biPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(biPhone);

                //Email NVarChar Parameter
                SqlParameter sEmail = new SqlParameter("@email", patient.email);
                sEmail.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sEmail);

                //Address NVarChar Parameter
                SqlParameter sAddress = new SqlParameter("@address", patient.address);
                sAddress.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sAddress);

                //Nationality Integer Parameter
                SqlParameter iNationality = new SqlParameter("@nationalityId", patient.natioinality);
                iNationality.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationality);

                cmd.ExecuteNonQuery();
            }
        }
        //selects patient
        public static Patient patienSelect(int patientId)
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
        //deletes patient
        public static void patientDelete(Patient patient)
        {
            using(SqlCommand  cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Patient_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iPatientId = new SqlParameter("@patientId", patient.patientId);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iPatientId);
                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable getPatientListBYName(Patient pat)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Patient_Search_Name";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter sFirstName = new SqlParameter("@firstName", pat.firstName);
            sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
            cmd.Parameters.Add(sFirstName);

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
        public static DataTable getPatientListById(Patient pat)
        {
            SqlCommand cmd = new  SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Patient_Search_Id";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter iPatientId = new SqlParameter("@patientId", pat.patientId);
            iPatientId.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(iPatientId);

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public static DataTable getPatientListByPhone(Patient pat)
        {
            SqlCommand cmd = new  SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Patient_Search_Phone";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter bPhone = new SqlParameter("@phone", pat.phone);
            bPhone.SqlDbType = System.Data.SqlDbType.BigInt;
            cmd.Parameters.Add(bPhone);

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
    }
}
