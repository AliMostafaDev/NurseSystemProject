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
    public partial class frmAddEditUser : Form
    {
        private int _ID;
        private clsUser _User;

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode;

        public frmAddEditUser()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditUser(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "ADD USER";
                this.Text = "Add New User";
                _User = new clsUser();
            }
            else
            {
                lblTitle.Text = "EDIT USER";
                this.Text = "Edit User";
            }
        }

        private void _LoadData()
        {
            _User = clsUser.FindByUserID(_ID);

            if (_User == null)
            {
                MessageBox.Show("No User With ID = " + _ID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = _User.ID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            chkIsAdmin.Checked = _User.IsAdmin;
           
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
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

            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsAdmin = chkIsAdmin.Checked;

            if (_User.Save())
            {
                Mode = enMode.Update;
                lblID.Text = _User.ID.ToString();
                lblTitle.Text = "EDIT USER";
                this.Text = "Edit User";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Error: Data Is Not Saved Successfully", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorProvider1.SetError(txtUserName, "User Name cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtUserName, string.Empty);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
