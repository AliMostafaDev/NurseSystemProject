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
    public partial class frmAddEditNurse : Form
    {
        private int _ID;
        private clsNurse _Nurse;

        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode;

        public void RemoveSalaryDetails()
        { 
            label2.Visible = false;
            txtSalary.Visible = false;
            txtSalary.Text = "0";
        }

        public frmAddEditNurse()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditNurse(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "ADD NURSE";
                this.Text = "Add New Nurse";
                _Nurse = new clsNurse();
            }
            else
            {
                lblTitle.Text = "EDIT NURSE";
                this.Text = "Edit Nurse";
            }
        }

        private void _LoadData()
        {
            _Nurse = clsNurse.FindByNurseID(_ID);

            if (_Nurse == null)
            {
                MessageBox.Show("No Nurse With ID = " + _ID, "Nurse Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = _Nurse.ID.ToString();
            txtFirstName.Text = _Nurse.FirstName;
            txtLastName.Text = _Nurse.LastName;
            rbMale.Checked = _Nurse.Gender == 'M';
            rbFemale.Checked = _Nurse.Gender == 'F';
            dtpDateOfBirth.Value = _Nurse.DateOfBirth;
            txtPhoneNumber.Text = _Nurse.PhoneNumber;
            txtEmail.Text = _Nurse.Email;
            txtAddress.Text = _Nurse.Address;
            txtSalary.Text = _Nurse.Salary.ToString();
        }

        private void frmAddEditNurse_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private bool _HasValidations()
        {
            this.ValidateChildren();
            foreach (Control control in gb.Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_HasValidations())
            {
                MessageBox.Show("Some fields are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Nurse.FirstName = txtFirstName.Text.Trim();
            _Nurse.LastName = txtLastName.Text.Trim();
            _Nurse.DateOfBirth = dtpDateOfBirth.Value;
            _Nurse.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Nurse.Email = txtEmail.Text.Trim();
            _Nurse.Address = txtAddress.Text.Trim();
            _Nurse.Gender = rbMale.Checked ? 'M' : 'F';
            _Nurse.Salary = Convert.ToInt32(txtSalary.Text.Trim());

            if (_Nurse.Save())
            {
                Mode = enMode.Update;
                lblID.Text = _Nurse.ID.ToString();
                lblTitle.Text = "EDIT NURSE";
                this.Text = "Edit Nurse";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Error: Data Is Not Saved Successfully", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                errorProvider1.SetError(txtFirstName, "First Name cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtFirstName, string.Empty);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                errorProvider1.SetError(txtLastName, "Last Name cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtLastName, string.Empty);
            };
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                errorProvider1.SetError(txtPhoneNumber, "Phone Number cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPhoneNumber, string.Empty);
            };
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Email cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            };
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                errorProvider1.SetError(txtAddress, "Address cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtAddress, string.Empty);
            };
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalary.Text.Trim()))
            {
                errorProvider1.SetError(txtSalary, "Salary cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalary, string.Empty);
            };
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
