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
    public partial class frmDoctorDetails : Form
    {
        private int _ID;
        private clsDoctor _Doctor;

        public void RemoveSalaryDetails()
        {
            label2.Visible = false;
            lblSalary.Visible = false;
        }

        public frmDoctorDetails(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmDoctorDetails_Load(object sender, EventArgs e)
        {
            _Doctor = clsDoctor.FindByDoctorID(_ID);

            if (_Doctor == null)
            {
                MessageBox.Show("No Doctor Found", "Doctor Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = "[" + _Doctor.ID.ToString() + "]";
            lblFirstName.Text = _Doctor.FirstName;
            lblLastName.Text = _Doctor.LastName;
            lblGender.Text = _Doctor.Gender == 'M' ? "Male" : "Fermale";
            lblMajor.Text = _Doctor.Major;
            lblDateOfBirth.Text = _Doctor.DateOfBirth.ToShortDateString();
            lblPhoneNumber.Text = _Doctor.PhoneNumber;
            lblEmail.Text = _Doctor.Email;
            lblAddress.Text = _Doctor.Address;
            lblSalary.Text = _Doctor.Salary.ToString() + " $";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
