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
    public partial class frmAddEditPatientService : Form
    {
        private int _ID;
        private clsPatientService _PatientService;

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode;


        private clsPatient _Patient = null;
        private clsNurse _Nurse = null;
        private clsDoctor _Doctor = null;
        public frmAddEditPatientService()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddEditPatientService(int ID)
        {
            InitializeComponent();
            _ID = ID;
            Mode = enMode.Update;
        }

        private void _LoadPatientData()
        {
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
        private void _ResetPatientData()
        {
            lblID.Text = "??";
            lblFirstName.Text = "[???]";
            lblSecondName.Text = "[???]";
            lblLastName.Text = "[???]";
            lblGender.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblPhoneNumber.Text = "[???]";
            lblEmail.Text = "[???]";
            lblAddress.Text = "[???]";
            lblWeight.Text = "[???]";
            lblAge.Text = "[???]";
        }

        private void _LoadNurseData()
        {
            lblNurseID.Text = "[" + _Nurse.ID.ToString() + "]";
            lblNurseFirstName.Text = _Nurse.FirstName;
            lblNurseLastName.Text = _Nurse.LastName;
            lblNurseGender.Text = _Nurse.Gender == 'M' ? "Male" : "Fermale";
            lblNurseDateOfBirth.Text = _Nurse.DateOfBirth.ToShortDateString();
            lblNursePhoneNumber.Text = _Nurse.PhoneNumber;
            lblNurseEmail.Text = _Nurse.Email;
            lblNurseAddress.Text = _Nurse.Address;
        }
        private void _ResetNurseData()
        {
            lblNurseID.Text = "??";
            lblNurseFirstName.Text = "[???]";
            lblNurseLastName.Text = "[???]";
            lblNurseGender.Text = "[???]";
            lblNurseDateOfBirth.Text = "[???]";
            lblNursePhoneNumber.Text = "[???]";
            lblNurseEmail.Text = "[???]";
            lblNurseAddress.Text = "[???]";
        }

        private void _LoadDoctorData()
        {
            lblDoctorID.Text = "[" + _Doctor.ID.ToString() + "]";
            lblDoctorFirstName.Text = _Doctor.FirstName;
            lblDoctorLastName.Text = _Doctor.LastName;
            lblDoctorGender.Text = _Doctor.Gender == 'M' ? "Male" : "Fermale";
            lblDoctorMajor.Text = _Doctor.Major;
            lblDoctorDateOfBirth.Text = _Doctor.DateOfBirth.ToShortDateString();
            lblDoctorPhoneNumber.Text = _Doctor.PhoneNumber;
            lblDoctorEmail.Text = _Doctor.Email;
            lblDoctorAddress.Text = _Doctor.Address;
            
        }
        private void _ResetDoctorData()
        {
            lblDoctorID.Text = "??";
            lblDoctorFirstName.Text = "[???]";
            lblDoctorLastName.Text = "[???]";
            lblDoctorGender.Text = "[???]";
            lblDoctorMajor.Text = "[???]";
            lblDoctorDateOfBirth.Text = "[???]";
            lblDoctorPhoneNumber.Text = "[???]";
            lblDoctorEmail.Text = "[???]";
            lblDoctorAddress.Text = "[???]";
            
        }


        private void _LoadPatientServiceData()
        {
            _PatientService = clsPatientService.FindByPatientServiceID(_ID);

            if (_PatientService == null)
            {
                MessageBox.Show("No Application With ID = " + _ID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_PatientService.Patient != null)
            {
                _Patient = _PatientService.Patient;
                txtPatientSelectBy.Text = _Patient.ID.ToString();
                _LoadPatientData();
            }

            if (_PatientService.Nurse != null)
            {
                _Nurse = _PatientService.Nurse;
                txtNurseSelectBy.Text = _Nurse.ID.ToString();
                _LoadNurseData();
            }

            if (_PatientService.Doctor != null)
            {
                _Doctor = _PatientService.Doctor;
                txtDoctorSelectBy.Text = _Doctor.ID.ToString();
                _LoadDoctorData();
            }

            lblPatientServiceID.Text = _PatientService.ID.ToString();
            dtpStartingDate.Value = _PatientService.StartingDate;
            cbPeriod.SelectedItem = _PatientService.Period;
            txtHospitalName.Text = _PatientService.HospitalName;
            cbShift.SelectedItem = _PatientService.Shift;
            txtPatientDiagnostic.Text = _PatientService.PatientDiagnostic;
            txtApplicationRequest.Text = _PatientService.ApplicationRequest;
            txtTotalAmount.Text = _PatientService.TotalAmount.ToString();
            txtAmountPaid.Text = _PatientService.AmountPaid.ToString();
            txtEquipmentsNeeded.Text = _PatientService.EquipmentsNeeded;

            string[] Services = _PatientService.Services.Split(',');
            for (int i = 0; i < chkLBServices.Items.Count; i++)
            {
                if (Services.Contains(chkLBServices.Items[i].ToString()))
                {
                    chkLBServices.SetItemChecked(i, true);
                }
            }

        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                this.Text = "Add New Bill";
                _PatientService = new clsPatientService();
            }
            else
            {
                this.Text = "Edit Bill";
            }

            txtPatientSelectBy.Focus();
            cbPatientSelectBy.SelectedIndex = 0;
            cbNurseSelectBy.SelectedIndex = 0;
            cbDoctorSelectBy.SelectedIndex = 0;

            cbPeriod.SelectedIndex = 0;
            cbShift.SelectedIndex = 0;

            _LoadServices();
        }


        private void _LoadServices()
        {
            DataTable dtServices = clsService.GetAllServices();

            foreach (DataRow row in dtServices.Rows)
            {
                chkLBServices.Items.Add((string)row["Name"]);
            }
            chkLBServices.SelectedIndex = 0;
        }

        private void frmAddEditPatientService_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (Mode == enMode.Update)
            {
                _LoadPatientServiceData();
            }

            
        }

        private void cbPatientSelectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPatientSelectBy.Text = "";
            txtPatientSelectBy.Focus();
        }

        private void cbNurseSelectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNurseSelectBy.Text = "";
            txtNurseSelectBy.Focus();
        }

        private void cbDoctorSelectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDoctorSelectBy.Text = "";
            txtDoctorSelectBy.Focus();
        }

        private void btnSelectPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientSelectBy.Text.Trim()))
            {
                _ResetPatientData();
                _Patient = null;
                MessageBox.Show("Text Box Is Empty, Please select a patient", "Empty TextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbPatientSelectBy.SelectedIndex == 0)
            {
                _Patient = clsPatient.FindByPatientID(Convert.ToInt32(txtPatientSelectBy.Text.Trim()));

                if (_Patient == null )
                {
                    _ResetPatientData();
                    MessageBox.Show("Patient Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _LoadPatientData();
            }
            else if (cbPatientSelectBy.SelectedIndex == 1)
            {
                _Patient = clsPatient.FindByPatientPhoneNumber(txtPatientSelectBy.Text.Trim());

                if (_Patient == null)
                {
                    _ResetPatientData();
                    MessageBox.Show("Patient Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _LoadPatientData();
            }
        }

        private void txtPatientSelectBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbPatientSelectBy.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNurseSelectBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbNurseSelectBy.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void txtDoctorSelectBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbDoctorSelectBy.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcPatientService.SelectedIndex = 1;
            txtNurseSelectBy.Focus();
        }

        private void btnSelectNurse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNurseSelectBy.Text.Trim()))
            {
                _ResetNurseData();
                _Nurse = null;
                MessageBox.Show("Text Box Is Empty, Please select a nurse", "Empty TextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbNurseSelectBy.SelectedIndex == 0)
            {
                _Nurse = clsNurse.FindByNurseID(Convert.ToInt32(txtNurseSelectBy.Text.Trim()));

                if (_Nurse == null)
                {
                    _ResetNurseData();
                    MessageBox.Show("Nurse Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _LoadNurseData();
            }
            else if (cbNurseSelectBy.SelectedIndex == 1)
            {
                _Nurse = clsNurse.FindByNurseFirstName(txtNurseSelectBy.Text.Trim());

                if (_Nurse == null)
                {
                    _ResetNurseData();
                    MessageBox.Show("Nurse Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _LoadNurseData();
            }
        }

        private void btnNurseNext_Click(object sender, EventArgs e)
        {
            tcPatientService.SelectedIndex = 2;
            txtDoctorSelectBy.Focus();
        }

        private void btnSelectDoctor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoctorSelectBy.Text.Trim()))
            {
                _ResetDoctorData();
                _Doctor = null;
                MessageBox.Show("Text Box Is Empty, Please select a doctor", "Empty TextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbDoctorSelectBy.SelectedIndex == 0)
            {
                _Doctor = clsDoctor.FindByDoctorID(Convert.ToInt32(txtDoctorSelectBy.Text.Trim()));

                if (_Doctor == null)
                {
                    _ResetDoctorData();
                    MessageBox.Show("Doctor Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _LoadDoctorData();
            }
            else if (cbDoctorSelectBy.SelectedIndex == 1)
            {
                _Doctor = clsDoctor.FindByDoctorFirstName(txtDoctorSelectBy.Text.Trim());

                if (_Doctor == null)
                {
                    _ResetDoctorData();
                    MessageBox.Show("Doctor Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _LoadDoctorData();
            }
        }

        private void chkLBServices_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < chkLBServices.Items.Count; i++)
            {
                if (i == e.Index)
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        sum += clsService.FindByServiceName(chkLBServices.Items[i].ToString()).SalePrice;
                    }
                }
                else
                {
                    if (chkLBServices.GetItemChecked(i))
                    {
                        sum += clsService.FindByServiceName(chkLBServices.Items[i].ToString()).SalePrice;
                    }
                }
            }

            txtTotalAmount.Text = sum.ToString();   
        }

        private bool _HasValidations()
        {
            this.ValidateChildren();
            foreach (Control control in gbDetails.Controls)
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

            if (_Patient == null)
            {
                MessageBox.Show("Please select a patient!", "No Patient Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Nurse == null && _Doctor == null)
            {
                MessageBox.Show("Please select a nurse or a doctor!", "Neither a nurse not a doctor is selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(txtTotalAmount.Text) < Convert.ToInt32(txtAmountPaid.Text))
            {
                MessageBox.Show("Amount paid is larger than the total amount!", "Amount paid error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PatientService.PatientID = _Patient.ID;
            
            if (_Nurse != null)
            {
                _PatientService.NurseID = _Nurse.ID;
            }
            else
            {
                _PatientService.NurseID = -1;
            }

            if (_Doctor != null)
            {
                _PatientService.DoctorID = _Doctor.ID;
            }
            else
            {
                _PatientService.DoctorID = -1;
            }

            _PatientService.Services = string.Join(",", chkLBServices.CheckedItems.Cast<string>());
            _PatientService.StartingDate = dtpStartingDate.Value;
            if (Mode == enMode.AddNew)
                _PatientService.ApplicationDate = DateTime.Now;
            _PatientService.Period = cbPeriod.Text.Trim();
            _PatientService.Shift = cbShift.Text.Trim();
            _PatientService.EquipmentsNeeded = txtEquipmentsNeeded.Text.Trim();
            _PatientService.PatientDiagnostic = txtPatientDiagnostic.Text.Trim();
            _PatientService.HospitalName = txtHospitalName.Text.Trim();
            _PatientService.ApplicationRequest = txtApplicationRequest.Text.Trim();
            _PatientService.TotalAmount = Convert.ToInt32(txtTotalAmount.Text.Trim());
            _PatientService.AmountPaid = Convert.ToInt32(txtAmountPaid.Text.Trim());


            if (_PatientService.Save())
            {
                Mode = enMode.Update;
                lblPatientServiceID.Text = _PatientService.ID.ToString();
                this.Text = "Edit Application";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Error: Data Is Not Saved Successfully", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHospitalName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHospitalName.Text.Trim()))
            {
                errorProvider1.SetError(txtHospitalName, "Hospital Name cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtHospitalName, string.Empty);
            };
        }

        private void txtPatientDiagnostic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientDiagnostic.Text.Trim()))
            {
                errorProvider1.SetError(txtPatientDiagnostic, "Patient Diagnostic cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPatientDiagnostic, string.Empty);
            };
        }

        private void txtApplicationRequest_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApplicationRequest.Text.Trim()))
            {
                errorProvider1.SetError(txtApplicationRequest, "Application Request cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtApplicationRequest, string.Empty);
            };
        }

        private void txtTotalAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalAmount.Text.Trim()))
            {
                errorProvider1.SetError(txtTotalAmount, "Total Amount cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTotalAmount, string.Empty);
            };
        }

        private void txtAmountPaid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmountPaid.Text.Trim()))
            {
                errorProvider1.SetError(txtAmountPaid, "Amount Paid cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAmountPaid, string.Empty);
            };
        }

        private void btnDoctorNext_Click(object sender, EventArgs e)
        {
            tcPatientService.SelectedIndex = 3;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriod.SelectedIndex == 11)
            {
                cbShift.SelectedIndex = 2;
            }
            else
            {
                cbShift.SelectedIndex = 0;
            }
        }

        private void cbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShift.SelectedIndex == 2)
            {
                cbPeriod.SelectedIndex = 11;
            }
            else 
            {
                cbPeriod.SelectedIndex = 1;
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
