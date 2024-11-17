using NurseSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseSystem.BusinessLayer
{
    public class clsDoctor
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string Major {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Salary {  get; set; }

        public clsDoctor()
        {
            ID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Gender = 'M';
            Major = string.Empty;
            DateOfBirth = DateTime.Now;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Salary = 0;
            _Mode = enMode.AddNew;
        }
        private clsDoctor(int ID, string FirstName, string LastName, char Gender, string Major,
                 DateTime DateOfBirth, string PhoneNumber, string Email, string Address, int Salary)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Major = Major;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.Salary = Salary; 
            _Mode = enMode.Update;
        }


        private bool _AddNewDoctor()
        {
            this.ID = clsDoctorData.AddNewDoctor(FirstName, LastName, Gender, Major, DateOfBirth,
                    PhoneNumber, Email, Address, Salary);
            return this.ID != -1;
        }

        private bool _Update()
        {
            return clsDoctorData.UpdateDoctor(ID, FirstName, LastName, Gender, Major, DateOfBirth,
                    PhoneNumber, Email, Address, Salary);
        }

        public static clsDoctor FindByDoctorID(int ID)
        {
            string FirstName = "", LastName = "", Major = "", PhoneNumber = "", Email = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'M';
            int Salary = 0;

            bool isFound = clsDoctorData.GetDoctorInfoByID(ID, ref FirstName, ref LastName, ref Gender,
                ref Major, ref DateOfBirth, ref PhoneNumber, ref Email, ref Address, ref Salary);

            if (isFound)
                return new clsDoctor(ID, FirstName, LastName, Gender, Major, DateOfBirth, PhoneNumber,
                    Email, Address, Salary);
            else
                return null;
        }

        public static clsDoctor FindByDoctorFirstName(string FirstName)
        {
            string LastName = "", Major = "", PhoneNumber = "", Email = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'M';
            int Salary = 0, ID = -1;

            bool isFound = clsDoctorData.GetDoctorInfoByFirstName(FirstName, ref ID, ref LastName, ref Gender,
                ref Major, ref DateOfBirth, ref PhoneNumber, ref Email, ref Address, ref Salary);

            if (isFound)
                return new clsDoctor(ID, FirstName, LastName, Gender, Major, DateOfBirth, PhoneNumber,
                    Email, Address, Salary);
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor())
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

        public static DataTable GetAllDoctors()
        {
            return clsDoctorData.GetAllDoctors();
        }

        public static DataTable GetAllDoctorsWithoutSalary()
        {
            return clsDoctorData.GetAllDoctorsWithoutSalary();
        }

        public static bool DeleteDoctor(int ID)
        {
            return clsDoctorData.DeleteDoctor(ID);
        }
    }
}
