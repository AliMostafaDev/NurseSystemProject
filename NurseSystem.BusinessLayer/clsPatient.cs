using NurseSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseSystem.BusinessLayer
{
    public class clsPatient
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }   
        public string Address { get; set; }
        public byte Weight {  get; set; }
        public int Age { get; set; }

        public clsPatient()
        {
            ID = -1;
            FirstName = string.Empty;
            SecondName = string.Empty;
            LastName = string.Empty;
            Gender = 'M';
            DateOfBirth = DateTime.Now;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Weight = 0;
            _Mode = enMode.AddNew;
        }
        private clsPatient(int ID, string FirstName, string SecondName, string LastName, char Gender,
                    DateTime DateOfBirth, string PhoneNumber, string Email, string Address, byte Weight, int Age)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.Weight = Weight;
            this.Age = Age;
            _Mode = enMode.Update;
        }


        private bool _AddNewPatient()
        {
            this.ID = clsPatientData.AddNewPatient(FirstName, SecondName, LastName, Gender, DateOfBirth,
                    PhoneNumber, Email, Address, Weight);
            return this.ID != -1;
        }

        private bool _Update()
        {
            return clsPatientData.UpdatePatient(ID, FirstName, SecondName, LastName, Gender, DateOfBirth,
                    PhoneNumber, Email, Address, Weight);
        }

        public static clsPatient FindByPatientID(int ID)
        {
            string FirstName = "", SecondName = "", LastName = "", PhoneNumber = "", Email = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'M';
            byte Weight = 0;
            int Age = 0;

            bool isFound = clsPatientData.GetPatientInfoByID(ID, ref FirstName, ref SecondName, ref LastName,
                ref Gender, ref DateOfBirth, ref PhoneNumber, ref Email, ref Address, ref Weight, ref Age);

            if (isFound)
                return new clsPatient(ID, FirstName, SecondName, LastName, Gender, DateOfBirth, PhoneNumber, Email, Address, Weight, Age);
            else
                return null;
        }

        public static clsPatient FindByPatientPhoneNumber(string PhoneNumber)
        {
            int ID = -1;
            string FirstName = "", SecondName = "", LastName = "", Email = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'M';
            byte Weight = 0;
            int Age = 0;

            bool isFound = clsPatientData.GetPatientInfoByPhoneNumber(PhoneNumber, ref ID, ref FirstName, ref SecondName, ref LastName,
                ref Gender, ref DateOfBirth, ref Email, ref Address, ref Weight, ref Age);

            if (isFound)
                return new clsPatient(ID, FirstName, SecondName, LastName, Gender, DateOfBirth, PhoneNumber, Email, Address, Weight, Age);
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
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

        public static DataTable GetAllPatients()
        {
            return clsPatientData.GetAllPatients();
        }

        public static bool DeletePatient(int ID)
        {
            return clsPatientData.DeletePateint(ID);
        }

    }
}
