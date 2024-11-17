using NurseSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseSystem.PresentationLayer
{
    public partial class frmAddEditPatient : Form
    {
        private int _ID = -1;
        private clsPatient _Patient;

        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode;



        public frmAddEditPatient()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditPatient(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "ADD PATIENT";
                this.Text = "Add New Patient";
                _Patient = new clsPatient();
            }
            else
            {
                lblTitle.Text = "EDIT PATIENT";
                this.Text = "Edit Patient";
            }
        }

        private void _LoadData()
        {
            _Patient = clsPatient.FindByPatientID(_ID);

            if (_Patient == null)
            {
                MessageBox.Show("No Patient With ID = " + _ID, "Patient Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = _Patient.ID.ToString();
            txtFirstName.Text = _Patient.FirstName;
            txtSecondName.Text = _Patient.SecondName;
            txtLastName.Text = _Patient.LastName;
            rbMale.Checked = _Patient.Gender == 'M';
            rbFemale.Checked = _Patient.Gender == 'F';
            dtpDateOfBirth.Value = _Patient.DateOfBirth;
            txtPhoneNumber.Text = _Patient.PhoneNumber;
            txtEmail.Text = _Patient.Email;
            txtAddress.Text = _Patient.Address;
            txtWeight.Text = _Patient.Weight.ToString();
        }

        private void frmAddEditPatient_Load(object sender, EventArgs e)
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

            _Patient.FirstName = txtFirstName.Text.Trim();
            _Patient.SecondName = txtSecondName.Text.Trim();
            _Patient.LastName = txtLastName.Text.Trim();
            _Patient.DateOfBirth = dtpDateOfBirth.Value;
            _Patient.PhoneNumber = txtPhoneNumber.Text.Trim();
            _Patient.Email = txtEmail.Text.Trim();
            _Patient.Address = txtAddress.Text.Trim();
            _Patient.Gender = rbMale.Checked ? 'M' : 'F';
            _Patient.Weight = Convert.ToByte(txtWeight.Text.Trim());

            if (_Patient.Save())
            {
                Mode = enMode.Update;
                lblID.Text = _Patient.ID.ToString();
                lblTitle.Text = "EDIT PATIENT";
                this.Text = "Edit Patient";
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
            };
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text.Trim()))
            {
                errorProvider1.SetError(txtWeight, "Weight cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtWeight, string.Empty);
            };
        }
    }
}
