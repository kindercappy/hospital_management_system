﻿using System;
using System.Collections.Generic;
using System.Data;
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
        private int iStaffId;
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
        private int iStaffShift;
        //Properties
        public int staffId
        {
            get
            {
                return iStaffId;
            }
            set
            {
                iStaffId = value;
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
        public int staffShift
        {
            get
            {
                return iStaffShift;
            }
            set
            {
                iStaffShift = value;
            }
        }
    }

    public class StaffManager
    {
        //saves staff
        public static void staffSave(Staff staff)
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
                SqlParameter iNationality = new SqlParameter("@nationality", staff.natioinality);
                iNationality.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationality);
                //StaffShift
                SqlParameter iStaffShift = new SqlParameter("@staffShift", staff.staffShift);
                iStaffShift.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iStaffShift);
                
                cmd.ExecuteNonQuery();
            }
        }
        //updates staff
        public static void staffUpdate(Staff staff)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //StaffId Integer Parameter
                SqlParameter iStaffId = new SqlParameter("staffId", staff.staffId);
                iStaffId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iStaffId);

                //FirstName NVarChar Parameter
                SqlParameter sFirstName = new SqlParameter("@firstName", staff.firstName);
                sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sFirstName);

                //LastName NVarChar Parameter
                SqlParameter sLastName = new SqlParameter("@lastName", staff.lastName);
                sLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sLastName);

                //Department Integer Parameter
                SqlParameter iDepartment = new SqlParameter("@department", staff.department);
                iDepartment.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iDepartment);

                //Age Integer Parameter
                SqlParameter iAge = new SqlParameter("@age", staff.age);
                iAge.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iAge);

                //Sex NVarChar Parameter
                SqlParameter sSex = new SqlParameter("@sex", staff.sex);
                sSex.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sSex);

                //HeightFt Integer Parameter
                SqlParameter iHeightFt = new SqlParameter("@heightFt", staff.heightFt);
                iHeightFt.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightFt);

                //HeightInch Integer Parameter
                SqlParameter iHeightInch = new SqlParameter("@heightInch", staff.heightInch);
                iHeightInch.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iHeightInch);

                //Weight Integer Parameter
                SqlParameter iWeight = new SqlParameter("@weight", staff.weight);
                iWeight.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iWeight);

                //Phone Integer Parameter
                SqlParameter iPhone = new SqlParameter("@phone", staff.phone);
                iPhone.SqlDbType = System.Data.SqlDbType.BigInt;
                cmd.Parameters.Add(iPhone);

                //Email NVarChar Parameter
                SqlParameter sEmail = new SqlParameter("@email", staff.email);
                sEmail.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sEmail);

                //Address NVarChar Parameter
                SqlParameter sAddress = new SqlParameter("@address", staff.address);
                sAddress.SqlDbType = System.Data.SqlDbType.NVarChar;
                cmd.Parameters.Add(sAddress);

                //Nationality Integer Parameter
                SqlParameter iNationalityId = new SqlParameter("@nationalityId", staff.natioinality);
                iNationalityId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iNationalityId);

                //staffShift Integer param
                SqlParameter iStaffShift = new SqlParameter("@staffShift", staff.staffShift);
                iStaffShift.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iStaffShift);

                cmd.ExecuteNonQuery();
            }
        }
        //deletes staff
        public static void staffDelete(Staff staff)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Common.getConnection();
                cmd.CommandText = "Staff_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //StaffId Integer
                SqlParameter iStaffId = new SqlParameter("@staffId", staff.staffId);
                iStaffId.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(iStaffId);

                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable getStaffListByName(Staff staff)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Search_Name";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter sFirstName = new SqlParameter("@firstName", staff.firstName);
            sFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
            cmd.Parameters.Add(sFirstName);

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public static DataTable getStaffListById(Staff staff)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Search_Id";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter iStaffId = new SqlParameter("@staffId", staff.staffId);
            iStaffId.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(iStaffId);

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
        public static DataTable getStaffListByPhone(Staff staff)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.Connection = Common.getConnection();
            cmd.CommandText = "Staff_Search_Phone";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter bPhone = new SqlParameter("@phone", staff.phone);
            bPhone.SqlDbType = System.Data.SqlDbType.BigInt;
            cmd.Parameters.Add(bPhone);

            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;

        }
    }
}

