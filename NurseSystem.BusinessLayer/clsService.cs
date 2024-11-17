using NurseSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseSystem.BusinessLayer
{
    public class clsService
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BasicPrice { get; set; }
        public int SalePrice {  get; set; }

        public clsService()
        {
            ID = -1;
            Name = string.Empty;
            Description = string.Empty;
            BasicPrice = 0;
            SalePrice = 0;
            _Mode = enMode.AddNew;
        }

        public clsService(int ID, string Name, string Description, int BasicPrice, int SalePrice)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.BasicPrice = BasicPrice;
            this.SalePrice = SalePrice;
            _Mode = enMode.Update;
        }

        private bool _AddNewService()
        {
            this.ID = clsServiceData.AddNewService(Name, Description, BasicPrice, SalePrice);
            return this.ID != -1;
        }

        public bool _Update()
        {
            return clsServiceData.UpdateService(ID, Name, Description, BasicPrice, SalePrice);
        }

        public static clsService FindByServiceID(int ID)
        {
            string Name = "", Description = "";
            int BasicSalary = 0, SaleSalary = 0;

            bool isFound = clsServiceData.GetServiceInfoByID(ID, ref Name, ref Description, ref BasicSalary,
                ref SaleSalary);

            if (isFound)
                return new clsService(ID, Name, Description, BasicSalary, SaleSalary);
            else
                return null;
        }

        public static clsService FindByServiceName(string Name)
        {
            string Description = "";
            int BasicSalary = 0, SaleSalary = 0, ID = -1;

            bool isFound = clsServiceData.GetServiceInfoByName(Name, ref ID, ref Description, ref BasicSalary,
                ref SaleSalary);

            if (isFound)
                return new clsService(ID, Name, Description, BasicSalary, SaleSalary);
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewService())
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

        public static DataTable GetAllServices()
        {
            return clsServiceData.GetAllServices();
        }

        public static bool DeleteService(int ID)
        {
            return clsServiceData.DeleteService(ID);
        }

    }
}
