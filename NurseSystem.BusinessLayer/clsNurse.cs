using NurseSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseSystem.BusinessLayer
{
    public class clsNurse
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }

        public clsNurse()
        {
            ID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Gender = 'M';
            DateOfBirth = DateTime.Now;
            PhoneNumber = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Salary = 0;
            _Mode = enMode.AddNew;
        }
        private clsNurse(int ID, string FirstName, string LastName, char Gender,
                 DateTime DateOfBirth, string PhoneNumber, string Email, string Address, int Salary)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.Salary = Salary;
            _Mode = enMode.Update;
        }


        private bool _AddNewNurse()
        {
            this.ID = clsNurseData.AddNewNurse(FirstName, LastName, Gender, DateOfBirth,
                    PhoneNumber, Email, Address, Salary);
            return this.ID != -1;
        }

        private bool _Update()
        {
            return clsNurseData.UpdateNurse(ID, FirstName, LastName, Gender, DateOfBirth,
                    PhoneNumber, Email, Address, Salary);
        }

        public static clsNurse FindByNurseID(int ID)
        {
            string FirstName = "", LastName = "", PhoneNumber = "", Email = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'M';
            int Salary = 0;

            bool isFound = clsNurseData.GetNurseInfoByID(ID, ref FirstName, ref LastName, ref Gender,
                ref DateOfBirth, ref PhoneNumber, ref Email, ref Address, ref Salary);

            if (isFound)
                return new clsNurse(ID, FirstName, LastName, Gender, DateOfBirth, PhoneNumber,
                    Email, Address, Salary);
            else
                return null;
        }

        public static clsNurse FindByNurseFirstName(string FirstName)
        {
            string LastName = "", PhoneNumber = "", Email = "", Address = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = 'M';
            int Salary = 0, ID = -1;

            bool isFound = clsNurseData.GetNurseInfoByFirstName(FirstName, ref ID, ref LastName, ref Gender,
                ref DateOfBirth, ref PhoneNumber, ref Email, ref Address, ref Salary);

            if (isFound)
                return new clsNurse(ID, FirstName, LastName, Gender, DateOfBirth, PhoneNumber,
                    Email, Address, Salary);
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewNurse())
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

        public static DataTable GetAllNurses()
        {
            return clsNurseData.GetAllNurses();
        }

        public static DataTable GetAllNursesWithoutSalary()
        {
            return clsNurseData.GetAllNursesWithoutSalary();
        }

        public static bool DeleteNurse(int ID)
        {
            return clsNurseData.DeleteNurse(ID);
        }
    }
}
