using NurseSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseSystem.PresentationLayer
{
    public partial class frmNurseDetails : Form
    {
        private int _ID;
        private clsNurse _Nurse;

        public void RemoveSalaryDetails()
        {
            label2.Visible = false;
            lblSalary.Visible = false;
        }
        public frmNurseDetails(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmNurseDetails_Load(object sender, EventArgs e)
        {
            _Nurse = clsNurse.FindByNurseID(_ID);

            if (_Nurse == null)
            {
                MessageBox.Show("No Nurse Found ", "Nurse Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = "[" + _Nurse.ID.ToString() + "]";
            lblFirstName.Text = _Nurse.FirstName;
            lblLastName.Text = _Nurse.LastName;
            lblGender.Text = _Nurse.Gender == 'M' ? "Male" : "Fermale";
            lblDateOfBirth.Text = _Nurse.DateOfBirth.ToShortDateString();
            lblPhoneNumber.Text = _Nurse.PhoneNumber;
            lblEmail.Text = _Nurse.Email;
            lblAddress.Text = _Nurse.Address;
            lblSalary.Text = _Nurse.Salary.ToString() + " $";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
