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
    public partial class frmAddEditDoctor : Form
    {
        private int _ID;
        private clsDoctor _Doctor;

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode;

        public void RemoveSalaryDetails()
        {
            label2.Visible = false;
            txtSalary.Visible = false;
            txtSalary.Text = "0";
        }

        public frmAddEditDoctor()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditDoctor(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "ADD DOCTOR";
                this.Text = "Add New Doctor";
                _Doctor = new clsDoctor();
            }
            else
            {
                lblTitle.Text = "EDIT DOCTOR";
                this.Text = "Edit Doctor";
            }
        }

        private void _LoadData()
        {
            _Doctor = clsDoctor.FindByDoctorID(_ID);

            if (_Doctor == null)
            {
                MessageBox.Show("No Doctor With ID = " + _ID, "Doctor Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = _Doctor.ID.ToString();
            txtFirstName.Text = _Doctor.FirstName;
            txtLastName.Text = _Doctor.LastName;
            rbMale.Checked = _Doctor.Gender == 'M';
            rbFemale.Checked = _Doctor.Gender == 'F';
            txtMajor.Text = _Doctor.Major;
            dtpDateOfBirth.Value = _Doctor.DateOfBirth;
            txtPhoneNumber.Text = _Doctor.PhoneNumber;
            txtEmail.Text = _Doctor.Email;
            txtAddress.Text = _Doctor.Address;
            txtSalary.Text = _Doctor.Salary.ToString();
        }

        private void frmAddEditDoctor_Load(object sender, EventArgs e)
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

            _Doctor.FirstName = txtFirstName.Text.Trim();
            _Doctor.LastName = txtLastName.Text.Trim();
            _Doctor.Major = txtMajor.Text.Trim();
            _Doctor.DateOfBirth = dtpDateOfBirth.Value;
            _Doctor.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Doctor.Email = txtEmail.Text.Trim();
            _Doctor.Address = txtAddress.Text.Trim();
            _Doctor.Gender = rbMale.Checked ? 'M' : 'F';
            _Doctor.Salary = Convert.ToInt32(txtSalary.Text.Trim());

            if (_Doctor.Save())
            {
                Mode = enMode.Update;
                lblID.Text = _Doctor.ID.ToString();
                lblTitle.Text = "EDIT DOCTOR";
                this.Text = "Edit Doctor";
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

        private void txtMajor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMajor.Text.Trim()))
            {
                errorProvider1.SetError(txtMajor, "Major cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtMajor, string.Empty);
            };
        }
    }
}
