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

namespace NurseSystem.PresentationLayer.Service
{
    public partial class frmAddEditService : Form
    {
        private int _ID;
        private clsService _Service;

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode;

        public frmAddEditService()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditService(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "ADD SERVICE";
                this.Text = "Add New Service";
                _Service = new clsService();
            }
            else
            {
                lblTitle.Text = "EDIT SERVICE";
                this.Text = "Edit Service";
            }
            txtServiceName.Focus();
        }

        private void _LoadData()
        {
            _Service = clsService.FindByServiceID(_ID);

            if (_Service == null)
            {
                MessageBox.Show("No Service With ID = " + _ID, "Service Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = _Service.ID.ToString();
            txtServiceName.Text = _Service.Name;
            txtDescription.Text = _Service.Description;
            txtBasicPrice.Text = _Service.BasicPrice.ToString();
            txtSalePrice.Text = _Service.SalePrice.ToString();

        }

        private void frmAddEditService_Load(object sender, EventArgs e)
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

            _Service.Name = txtServiceName.Text.Trim();
            _Service.Description = txtDescription.Text.Trim();
            _Service.BasicPrice = Convert.ToInt32(txtBasicPrice.Text.Trim());
            _Service.SalePrice = Convert.ToInt32(txtSalePrice.Text.Trim());

            if (_Service.Save())
            {
                Mode = enMode.Update;
                lblID.Text = _Service.ID.ToString();
                lblTitle.Text = "EDIT SERVICE";
                this.Text = "Edit Service";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Error: Data Is Not Saved Successfully", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtServiceName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceName.Text.Trim()))
            {
                errorProvider1.SetError(txtServiceName, "Service Name cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtServiceName, string.Empty);
            };
        }

        private void txtBasicPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBasicPrice.Text.Trim()))
            {
                errorProvider1.SetError(txtBasicPrice, "Basic Price cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtBasicPrice, string.Empty);
            };
        }

        private void txtSalePrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalePrice.Text.Trim()))
            {
                errorProvider1.SetError(txtSalePrice, "Sale Price cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtSalePrice, string.Empty);
            };
        }

        private void txtBasicPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
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
