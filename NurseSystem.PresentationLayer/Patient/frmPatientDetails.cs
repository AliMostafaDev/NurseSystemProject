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
    public partial class frmPatientDetails : Form
    {
        private int _ID;
        private clsPatient _Patient;
        public frmPatientDetails(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmShowPatientDetails_Load(object sender, EventArgs e)
        {
            _Patient = clsPatient.FindByPatientID(_ID);

            if (_Patient == null)
            {
                MessageBox.Show("No Patient Found", "Patient Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = "[" + _Patient.ID.ToString() + "]";
            lblFirstName.Text = _Patient.FirstName;
            lblSecondName.Text = _Patient.SecondName;
            lblLastName.Text = _Patient.LastName;
            lblGender.Text = _Patient.Gender == 'M' ? "Male" : "Fermale";
            lblDateOfBirth.Text = _Patient.DateOfBirth.ToShortDateString();
            lblPhoneNumber.Text = _Patient.PhoneNumber;
            lblEmail.Text = _Patient.Email;
            lblAddress.Text = _Patient.Address;
            lblWeight.Text = _Patient.Weight.ToString();
            lblAge.Text = _Patient.Age.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
