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
        //Doctor
        private static NewDoctor fNewDoctor;
        private static ExistingDoctor fExistingDoctor;
        private static DoctorShifts fDoctorShifts;
        //Staff
        private static NewStaff fNewStaff;
        private static ExistingStaff fExistingStaff;
        //Hospital
        private static HospitalMain fHospitalMain;

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


        public static void ShowMaximizeSubForm(Form frm, Form mdi)
            {
                frm.MdiParent = mdi;
                frm.Show();
                frm.BringToFront();
                frm.WindowState = FormWindowState.Maximized;
           }
     }
}

