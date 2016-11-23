using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospitalManagementSystem;

namespace hospitalManagementSystem
{
     public class CommonFormOperation
    {
        
        //Patient
        private static NewPatient fNewPatient;
        private static ExistingPatient fExistingPatient;
        private static BookAppointment fBookApp;
        //Doctor
        private static NewDoctor fNewDoctor;
        private static ExistingDoctor fExistingDoctor;
        private static DoctorShifts fDoctorShifts;
        private static AssignDoctorShifts fAssignDoctorShifts;
        //Staff
        private static NewStaff fNewStaff;
        private static ExistingStaff fExistingStaff;
        private static StaffShifts fStaffSfhits;
        private static AssignStaffShifts fAssignStaffShifts;
        //Hospital
        private static HospitalMain fHospitalMain;
        //Nationality
        private static Nationality fNationality;
        //Patient
        public static NewPatient newPatient
            {
                get
                {
                    if (fNewPatient == null || fNewPatient.IsDisposed)
                    {
                        fNewPatient = new NewPatient();
                    }

                    return fNewPatient;
                }
            }
        public static ExistingPatient existingPatient
            {
                get
                {
                    if ( fExistingPatient == null|| fExistingPatient.IsDisposed)
                    {
                        fExistingPatient = new ExistingPatient();
                    }
                        return fExistingPatient;
                }
            }
        public static BookAppointment bookApp
        {
            get
            {
                if(fBookApp == null || fBookApp.IsDisposed)
                {
                    fBookApp = new BookAppointment();
                }
                return fBookApp;
            }
        }    
        //Doctor
        public static NewDoctor newDoctor
        {
            get
            {
                if(fNewDoctor == null || fNewDoctor.IsDisposed)
                {
                    fNewDoctor = new NewDoctor();
                }
                return fNewDoctor;
            }
        }
        public static ExistingDoctor existingDoctor
        {
            get
            {
                if (fExistingDoctor == null || fExistingDoctor.IsDisposed)
                {
                    fExistingDoctor = new ExistingDoctor();
                }
                return fExistingDoctor;
            }
        }
        public static DoctorShifts doctorShifts
        {
            get
            {
                if(fDoctorShifts == null || fDoctorShifts.IsDisposed)
                {
                    fDoctorShifts = new DoctorShifts();
                }
                return fDoctorShifts;
            }
        }
        public static AssignDoctorShifts assignDoctorShifts
        {
            get
            {
                if(fAssignDoctorShifts == null || fAssignDoctorShifts.IsDisposed)
                {
                    fAssignDoctorShifts = new AssignDoctorShifts();
                }
                return fAssignDoctorShifts;
            }
        }

        //Staff
        public static NewStaff newStaff
        {
            get
            {
                if (fNewStaff == null||fNewStaff.IsDisposed)
                {
                    fNewStaff = new NewStaff();
                }
                return fNewStaff;
            }
        }
        public static ExistingStaff existingStaff
        {
            get
            {
                if (fExistingStaff == null || fExistingStaff.IsDisposed)
                {
                    fExistingStaff = new ExistingStaff();
                }
                return fExistingStaff;
            }
        }
        public static StaffShifts staffShifts
        {
            get
            {
                if(fStaffSfhits == null || fStaffSfhits.IsDisposed)
                {
                    fStaffSfhits = new StaffShifts();
                }
                return fStaffSfhits;
            }
        }
        public static AssignStaffShifts assignStaffShifts
        {
            get
            {
                if (fAssignStaffShifts == null || fAssignStaffShifts.IsDisposed)
                {
                    fAssignStaffShifts = new AssignStaffShifts();
                }
                return fAssignStaffShifts;
            }
        }
        //HospitalMain
        public static HospitalMain hospitalMain
        {
            get
            {
                if(fHospitalMain == null|| fHospitalMain.IsDisposed)
                {
                    fHospitalMain = new HospitalMain();
                }
                return fHospitalMain;
            }
        }
        //Nationality
        public static Nationality nationality
        {
            get
            {
                if(fNationality==null || fNationality.IsDisposed)
                {
                    fNationality = new Nationality();
                }
                return fNationality;
            }
        }

        public static void ShowMaximizeSubForm(Form frm, Form mdi)
            {
                frm.MdiParent = mdi;
                frm.Show();
                frm.BringToFront();
                frm.WindowState = FormWindowState.Maximized;
           }
     }
}

