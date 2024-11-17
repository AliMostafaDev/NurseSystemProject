using NurseSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NurseSystem.BusinessLayer
{
    public class clsPatientService
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID {  get; set; }
        public int PatientID { get; set; }
        public clsPatient Patient { get; set; }
        public int NurseID {  get; set; }
        public clsNurse Nurse { get; set; }
        public int DoctorID { get; set; }
        public clsDoctor Doctor { get; set; }
        public string Services {  get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Period { get; set; }
        public string Shift { get; set; }
        public string EquipmentsNeeded {  get; set; }
        public string PatientDiagnostic { get; set; }
        public string HospitalName { get; set; }
        public string ApplicationRequest { get; set; }
        public int TotalAmount { get; set; }
        public int AmountPaid { get; set; }

        public clsPatientService()
        {
            ID = -1;
            PatientID = -1;
            NurseID = -1;
            DoctorID = -1;
            Services = string.Empty;
            StartingDate = DateTime.Now;
            ApplicationDate = DateTime.Now;
            Period = string.Empty;
            Shift = string.Empty;
            EquipmentsNeeded = string.Empty;
            PatientDiagnostic = string.Empty;
            HospitalName = string.Empty;
            ApplicationRequest = string.Empty;
            TotalAmount = 0;
            AmountPaid = 0;
            _Mode = enMode.AddNew;
        }

        public clsPatientService(int ID, int PatientID, int NurseID, int DoctorID, string Services, DateTime StartingDate, DateTime ApplicationDate,
                            string Period, string Shift, string EquipmentsNeeded, string PatientDiagnostic, string HospitalName, string ApplicationRequest,
                            int TotalAmount, int AmountPaid)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            Patient = clsPatient.FindByPatientID(PatientID);
            this.NurseID = NurseID;
            Nurse = clsNurse.FindByNurseID(NurseID);
            this.DoctorID = DoctorID;
            Doctor = clsDoctor.FindByDoctorID(DoctorID);
            this.Services = Services;
            this.StartingDate = StartingDate;
            this.ApplicationDate = ApplicationDate;
            this.Period = Period;
            this.Shift = Shift;
            this.EquipmentsNeeded = EquipmentsNeeded;
            this.PatientDiagnostic = PatientDiagnostic;
            this.HospitalName = HospitalName;
            this.ApplicationRequest = ApplicationRequest;
            this.TotalAmount = TotalAmount;
            this.AmountPaid = AmountPaid;
            _Mode = enMode.Update;
        }

        private bool _AddNewPatientService()
        {
            this.ID = clsPatientServiceData.AddNewPatientService(PatientID, NurseID, DoctorID, Services, StartingDate, ApplicationDate, Period,
                    Shift, EquipmentsNeeded, PatientDiagnostic, HospitalName, ApplicationRequest, TotalAmount, AmountPaid);
            return this.ID != -1;
        }

        private bool _Update()
        {
            return clsPatientServiceData.UpdatePatientService(ID, PatientID, NurseID, DoctorID, Services, StartingDate, ApplicationDate, Period,
                    Shift, EquipmentsNeeded, PatientDiagnostic, HospitalName, ApplicationRequest, TotalAmount, AmountPaid);
        }

        public static clsPatientService FindByPatientServiceID(int ID)
        {
            int PatientID = -1, NurseID = -1, DoctorID = -1, TotalAmount = 0, AmountPaid = 0;
            DateTime StartingDate = DateTime.Now, ApplicationDate = DateTime.Now;    
            string Services = "", EquipmentsNeeded = "", Period = "", PatientDiagnostic = "", HospitalName = "", ApplicationRequest = "", Shift = "";

            bool isFound = clsPatientServiceData.GetPatientServiceInfoByID(ID, ref PatientID, ref NurseID, ref DoctorID, ref Services, ref StartingDate,
                            ref ApplicationDate, ref Period, ref Shift, ref EquipmentsNeeded, ref PatientDiagnostic, ref HospitalName, ref ApplicationRequest,
                            ref TotalAmount, ref AmountPaid);

            if (isFound)
                return new clsPatientService(ID, PatientID, NurseID, DoctorID, Services, StartingDate, ApplicationDate, Period, Shift,
                    EquipmentsNeeded, PatientDiagnostic, HospitalName, ApplicationRequest, TotalAmount, AmountPaid);
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatientService())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    break;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static DataTable GetAllPatientServices()
        {
            return clsPatientServiceData.GetAllPatientServices();
        }

        public static bool DeletePatientService(int ID)
        {
            return clsPatientServiceData.DeletePatientService(ID);
        }

        public static int GetAmountPaidForMonth(int Year, int Month)
        {
            return clsPatientServiceData.GetAmountPaidForMonth(Year, Month);
        }

        public static int GetAllAmountPaid()
        {
            return clsPatientServiceData.GetAllAmountPaid();
        }

        public static int GetCollectedMoney()
        {
            return clsPatientServiceData.GetCollectedMoney();
        } 

        public static bool UpdateCollectedMoney(int Money)
        {
            return clsPatientServiceData.UpdateCollectedMoney(Money);
        }


    }
}
