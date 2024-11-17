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
    public partial class frmPatientServiceDetails : Form
    {
        private int _ID;
        private clsPatientService _PatientService;
        public frmPatientServiceDetails(int ID)
        {
            InitializeComponent();
            _ID = ID;
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

        private void frmPatientServiceDetails_Load(object sender, EventArgs e)
        {
            _LoadServices();

            _PatientService = clsPatientService.FindByPatientServiceID(_ID);

            if (_PatientService == null)
            {
                MessageBox.Show("No Patient Service Found", "Patient Service Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPatientServiceID.Text = "[" + _PatientService.ID.ToString() + "]";
            lblPatientID.Text = "[" + _PatientService.PatientID.ToString() + "]";
            if (_PatientService.NurseID != -1)
                lblNurseID.Text = "[" + _PatientService.NurseID.ToString() + "]";
            if (_PatientService.DoctorID != -1)
                lblDoctorID.Text = "[" + _PatientService.DoctorID.ToString() + "]";

            txtStartingDate.Text = _PatientService.StartingDate.ToString();
            txtPeriod.Text = _PatientService.Period;
            txtHospitalName.Text = _PatientService.HospitalName;
            txtShift.Text = _PatientService.Shift;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
