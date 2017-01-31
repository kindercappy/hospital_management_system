using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalLibrary
{
    public class Appointment
    {
        private string sFirstName;
        private string sLastName;
        private int iDepatrmentId;
        private int iAge;
        private int iDoctorId;
        private string sSex;
        private long iPhone;
        private int iPatientId;
        private DateTime tAppTime;
        private int iappId;
        public int appId
        {
            get
            {
                return iappId;
            }
            set
            {
                iappId = value;
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
        public int departmentId
        {
            get
            {
                return iDepatrmentId;
            }
            set
            {
                iDepatrmentId = value;
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
        public DateTime appTime
        {
            get
            {
                return tAppTime;
            }
            set
            {
                tAppTime = value;
            }
        }
    }   
    public class AppointmentManager
    {
        public static void appointmentSave(Appointment app)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Appointment_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                // firstName NVarChar param
                SqlParameter sFirstName = new SqlParameter("@firstName", app.firstName);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);

                //lastName NvarChar param
                SqlParameter sLastName = new SqlParameter("@lastName", app.lastName);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);

                //departmentId Integer param
                SqlParameter iDepartment = new SqlParameter("@departmentId", app.departmentId);
                iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartment);

                //age Integer param
                SqlParameter iAge = new SqlParameter("@age", app.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);

                //doctorId Integer param
                SqlParameter iDoctorId = new SqlParameter("@doctorId", app.doctorId);
                iDoctorId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDoctorId);

                //sex NVarChar param
                SqlParameter sSex = new SqlParameter("@sex", app.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);

                //phone BigInt param
                SqlParameter iPhone = new SqlParameter("@phone", app.phone);
                iPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(iPhone);

                //appTime Time param
                SqlParameter tAppTime = new SqlParameter("@appTime", app.appTime);
                tAppTime.SqlDbType = System.Data.SqlDbType.DateTime;
                cmd.Parameters.Add(tAppTime);

                //patientId Integer param
                SqlParameter iPatientId = new SqlParameter("@patientId", app.patientId);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iPatientId);


                cmd.ExecuteNonQuery();
            }
        }
        public static void appointmentSelect(Appointment app)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Appointment_Select_By_PatientId";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iPatientId = new SqlParameter("@patientId", app.patientId);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(cmd);

                cmd.ExecuteNonQuery();
            }
        }        
        public static void AppointmentInfoUpdate(Appointment app)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Appointment_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //patientId Integer param
                SqlParameter iPatientId = new SqlParameter("@patientId",app.patientId);
                iPatientId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iPatientId);

                //firstName NVarChar param
                SqlParameter sFirstName = new SqlParameter("@firstName", app.firstName);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);

                //lastName NVarChar param
                SqlParameter sLastName = new SqlParameter("@lastNAme", app.lastName);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);

                //phone BigInt param
                SqlParameter bPhone = new SqlParameter("@phone", app.phone);
                bPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(bPhone);

                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable displayAppointmentByDoctorId(Appointment app)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Appointment_Select_By_DoctorId";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter iDoctorId = new SqlParameter("@doctorId", app.doctorId);
            iDoctorId.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(iDoctorId);

            cmd.ExecuteNonQuery();

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
        public static void deleteAppointmentByAppointmentId(Appointment app)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Appointment_Delete_By_AppointmentId";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter iAppointmentId = new SqlParameter("@appId", app.appId);
                iAppointmentId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAppointmentId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
