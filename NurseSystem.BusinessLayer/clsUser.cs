using NurseSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseSystem.BusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public clsUser()
        {
            ID = -1;
            UserName = "";
            Password = "";
            IsAdmin = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int ID, string UserName, string Password, bool IsAdmin)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            ID = clsUserData.AddNewUser(UserName, Password, IsAdmin);
            return ID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(ID, UserName, Password, IsAdmin);
        }

        public static clsUser FindByUserID(int ID)
        {
            string UserName = "", Password = "";
            bool IsAdmin = false;

            bool isFound = clsUserData.GetUserInfoByID(ID, ref UserName, ref Password, ref IsAdmin);
            if (isFound)
            {
                return new clsUser(ID, UserName, Password, IsAdmin);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {

            int ID = -1;
            bool IsAdmin = false;

            bool isFound = clsUserData.GetUserInfoByUsernameAndPassword(UserName, Password, ref ID, ref IsAdmin);
            if (isFound)
            {
                return new clsUser(ID, UserName, Password, IsAdmin);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

    }
}
