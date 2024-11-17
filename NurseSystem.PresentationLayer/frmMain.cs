using NurseSystem.BusinessLayer;
using NurseSystem.PresentationLayer.GlobalClasses;
using NurseSystem.PresentationLayer.Properties;
using NurseSystem.PresentationLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseSystem.PresentationLayer
{
    public partial class frmMain : Form
    {
        private DataTable _dtPatients = new DataTable();
        private DataTable _dtNurses = new DataTable();
        private DataTable _dtDoctors = new DataTable();
        private DataTable _dtPatientServices = new DataTable();

        private DataTable _dtUsers = new DataTable();
        private DataTable _dtServices = new DataTable();


        public frmMain()
        {
            InitializeComponent();

           
        }

        private void _LoadPatients()
        {
            _dtPatients = clsPatient.GetAllPatients();
            dgvPatients.DataSource = _dtPatients;

            if (dgvPatients.Rows.Count > 0 )
            {
                dgvPatients.Columns[0].HeaderText = "ID";
                dgvPatients.Columns[0].Width = 100;

                dgvPatients.Columns[1].HeaderText = "First Name";
                dgvPatients.Columns[1].Width = 150;

                dgvPatients.Columns[2].HeaderText = "Second Name";
                dgvPatients.Columns[2].Width = 150;

                dgvPatients.Columns[3].HeaderText = "Last Name";
                dgvPatients.Columns[3].Width = 150;

                dgvPatients.Columns[4].HeaderText = "Gender";
                dgvPatients.Columns[4].Width = 100;

                dgvPatients.Columns[5].HeaderText = "Date Of Birth";
                dgvPatients.Columns[5].Width = 150;

                dgvPatients.Columns[6].HeaderText = "Phone Number";
                dgvPatients.Columns[6].Width = 150;

                dgvPatients.Columns[7].HeaderText = "Email";
                dgvPatients.Columns[7].Width = 200;

                dgvPatients.Columns[8].HeaderText = "Address";
                dgvPatients.Columns[8].Width = 200;

                //dgvPatients.Width = 1360;
                dgvPatients.Width = 1130;
            }
            
        }

        private void _LoadNurses()
        {
            if (clsGlobal.CurrentUser.IsAdmin)
            {
                _dtNurses = clsNurse.GetAllNurses();
            }
            else
            {
                _dtNurses = clsNurse.GetAllNursesWithoutSalary();
            }

            dgvNurses.DataSource = _dtNurses;

            if (dgvNurses.Rows.Count > 0 )
            {
                dgvNurses.Columns[0].HeaderText = "ID";
                dgvNurses.Columns[0].Width = 100;

                dgvNurses.Columns[1].HeaderText = "First Name";
                dgvNurses.Columns[1].Width = 150;

                dgvNurses.Columns[2].HeaderText = "Last Name";
                dgvNurses.Columns[2].Width = 150;

                dgvNurses.Columns[3].HeaderText = "Gender";
                dgvNurses.Columns[3].Width = 90;

                dgvNurses.Columns[4].HeaderText = "Date Of Birth";
                dgvNurses.Columns[4].Width = 150;

                dgvNurses.Columns[5].HeaderText = "Phone Number";
                dgvNurses.Columns[5].Width = 150;

                dgvNurses.Columns[6].HeaderText = "Email";
                dgvNurses.Columns[6].Width = 200;

                dgvNurses.Columns[7].HeaderText = "Address";
                dgvNurses.Columns[7].Width = 200;

                if (clsGlobal.CurrentUser.IsAdmin)
                {
                    dgvNurses.Columns[8].HeaderText = "Salary";
                    dgvNurses.Columns[8].Width = 75;

                    //dgvNurses.Width = 1318;
                    dgvNurses.Width = 1130;
                    return;
                }
                //dgvNurses.Width = 1220;
                dgvNurses.Width = 1130;


            }


        }

        private void _LoadDoctors()
        {

            if (clsGlobal.CurrentUser.IsAdmin)
            {
                _dtDoctors = clsDoctor.GetAllDoctors();

            }
            else
            {
                _dtDoctors = clsDoctor.GetAllDoctorsWithoutSalary();
            }
            dgvDoctors.DataSource = _dtDoctors;

            if (dgvDoctors.Rows.Count > 0 )
            {
                dgvDoctors.Columns[0].HeaderText = "ID";
                dgvDoctors.Columns[0].Width = 100;

                dgvDoctors.Columns[1].HeaderText = "First Name";
                dgvDoctors.Columns[1].Width = 150;

                dgvDoctors.Columns[2].HeaderText = "Last Name";
                dgvDoctors.Columns[2].Width = 150;

                dgvDoctors.Columns[3].HeaderText = "Gender";
                dgvDoctors.Columns[3].Width = 90;

                dgvDoctors.Columns[4].HeaderText = "Major";
                dgvDoctors.Columns[4].Width = 150;

                dgvDoctors.Columns[5].HeaderText = "Date Of Birth";
                dgvDoctors.Columns[5].Width = 150;

                dgvDoctors.Columns[6].HeaderText = "Phone Number";
                dgvDoctors.Columns[6].Width = 150;

                dgvDoctors.Columns[7].HeaderText = "Address";
                dgvDoctors.Columns[7].Width = 200;

                if (clsGlobal.CurrentUser.IsAdmin)
                {
                    dgvDoctors.Columns[8].HeaderText = "Salary";
                    dgvDoctors.Columns[8].Width = 75;

                    //dgvDoctors.Width = 1268;
                    dgvDoctors.Width = 1130;
                    return;
                }

                //dgvDoctors.Width = 1190;
                dgvDoctors.Width = 1130;

            } 
        }

        private void _LoadPatientServices()
        {
            _dtPatientServices = clsPatientService.GetAllPatientServices();
            dgvPatientServices.DataSource = _dtPatientServices;

            if (dgvPatientServices.Rows.Count > 0)
            {
                dgvPatientServices.Columns[0].HeaderText = "ID";
                //dgvPatientServices.Columns[0].Width = 100;
                dgvPatientServices.Columns[0].Width = 80;

                dgvPatientServices.Columns[1].HeaderText = "Patient First Name";
                dgvPatientServices.Columns[1].Width = 150;

                dgvPatientServices.Columns[2].HeaderText = "Patient Last Name";
                dgvPatientServices.Columns[2].Width = 150;

                dgvPatientServices.Columns[3].HeaderText = "Nurse First Name";
                dgvPatientServices.Columns[3].Width = 150;

                dgvPatientServices.Columns[4].HeaderText = "Doctor First Name";
                dgvPatientServices.Columns[4].Width = 150;

                dgvPatientServices.Columns[5].HeaderText = "Amount Paid";
                //dgvPatientServices.Columns[5].Width = 150;
                dgvPatientServices.Columns[5].Width = 110;

                dgvPatientServices.Columns[6].HeaderText = "Total Amount";
                //dgvPatientServices.Columns[6].Width = 150;
                dgvPatientServices.Columns[6].Width = 110;

                dgvPatientServices.Columns[7].HeaderText = "Application Date";
                dgvPatientServices.Columns[7].Width = 200;


                //dgvPatientServices.Width = 1250;
                dgvPatientServices.Width = 1130;

            }

        }


        private void _LoadUsers()
        {
            _dtUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtUsers;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "ID";
                dgvUsers.Columns[0].Width = 150;

                dgvUsers.Columns[1].HeaderText = "User Name";
                dgvUsers.Columns[1].Width = 200;

                dgvUsers.Columns[2].HeaderText = "Password";
                dgvUsers.Columns[2].Width = 200;

                dgvUsers.Columns[3].HeaderText = "Is Admin";
                dgvUsers.Columns[3].Width = 75;

                dgvUsers.Width = 675;

            }

            int TotalAmountPaid = clsPatientService.GetAllAmountPaid();
            int CollectedMoney = clsPatientService.GetCollectedMoney();

            int MoneyToCollect = TotalAmountPaid - CollectedMoney;

            lblMoneyToCollect.Text = MoneyToCollect + " $";
        }

        private void _LoadServices()
        {
            _dtServices = clsService.GetAllServices();
            dgvServices.DataSource = _dtServices;

            if (dgvServices.Rows.Count > 0)
            {
                dgvServices.Columns[0].HeaderText = "ID";
                dgvServices.Columns[0].Width = 150;

                dgvServices.Columns[1].HeaderText = "Name";
                dgvServices.Columns[1].Width = 200;

                dgvServices.Columns[2].HeaderText = "Description";
                dgvServices.Columns[2].Width = 200;

                dgvServices.Columns[3].HeaderText = "Basic Price";
                dgvServices.Columns[3].Width = 150;

                dgvServices.Columns[4].HeaderText = "Sale Price";
                dgvServices.Columns[4].Width = 150;


                dgvServices.Width = 900;

            }
        }
       


        private void _LoadDefaultIndexesForComboBoxes()
        {
            cbPatientsFilterBy.SelectedIndex = 0;
            cbNursesFilterBy.SelectedIndex = 0;
            cbDoctorsFilterBy.SelectedIndex = 0;
            cbPatientServiceFilterBy.SelectedIndex = 0;
            cbServicesFilterBy.SelectedIndex = 0;
            cbUsersFilterBy.SelectedIndex = 0;

            cbYear.SelectedIndex = 0;
            cbMonth.SelectedIndex = 0;
        }

        private void _ClearAllDataGridViews()
        {
            _dtPatients.Clear();
            _dtNurses.Clear();
            _dtDoctors.Clear();
            _dtPatientServices.Clear();
            _dtUsers.Clear();
            _dtServices.Clear();

            dgvPatients.DataSource = _dtPatients;
            dgvNurses.DataSource = _dtNurses;
            dgvDoctors.DataSource = _dtDoctors;
            dgvPatientServices.DataSource = _dtPatientServices;
            dgvUsers.DataSource = _dtUsers;
            dgvServices.DataSource = _dtServices;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();

            _LoadDataForSelectedTabInHome();

            _LoadDefaultIndexesForComboBoxes();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                MessageBox.Show("Cannot Open Settings, User Is Not Admin.", "User Is Not Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tabControlMain.SelectedIndex = 1;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void _LoadDataForSelectedTabInHome()
        {
            switch (tabControlHome.SelectedIndex)
            {
                case 0:
                    _ClearAllDataGridViews();
                    _LoadPatients();
                    break;

                case 1:
                    _ClearAllDataGridViews();
                    _LoadNurses();
                    break;

                case 2:
                    _ClearAllDataGridViews();
                    _LoadDoctors();
                    break;

                case 3:
                    _ClearAllDataGridViews();
                    _LoadPatientServices();
                    break;
            }
        }

        private void _LoadDataForSelectedTabInSettings()
        {
            switch (tabControlSettings.SelectedIndex)
            {
                case 0:
                    _ClearAllDataGridViews();
                    _LoadServices();
                    break;

                case 1:
                    _ClearAllDataGridViews();
                    _LoadUsers();
                    break;
            }
        }

        private void tabControlHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadDataForSelectedTabInHome();
        }

        private void tabControlSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            _LoadDataForSelectedTabInSettings();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    _LoadDataForSelectedTabInHome();
                    break;

                case 1:
                    _LoadDataForSelectedTabInSettings();
                    break;

                case 2:
                    clsGlobal.CurrentUser = null;
                    this.Close();
                    break;
            }
        }

        private void cbPatientsFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPatientsFilterBy.Visible = (cbPatientsFilterBy.Text != "None");

            if (txtPatientsFilterBy.Visible)
            {
                txtPatientsFilterBy.Text = "";
                txtPatientsFilterBy.Focus();
            }
        }

        private void txtPatientsFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbPatientsFilterBy.Text)
            {
                case "ID":
                    FilterColumn = "ID";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Last Name":
                    FilterColumn = "Last Name";
                    break;

                case "Phone Number":
                    FilterColumn = "PhoneNumber";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtPatientsFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPatients.DefaultView.RowFilter = "";
            }
            else
            {
                _dtPatients.DefaultView.RowFilter = $"Convert({FilterColumn}, 'System.String') like '%{txtPatientsFilterBy.Text.Trim()}%'";
            }
        }

        private void cbNursesFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNursesFilterBy.Visible = (cbNursesFilterBy.Text != "None");

            if (txtNursesFilterBy.Visible)
            {
                txtNursesFilterBy.Text = "";
                txtNursesFilterBy.Focus();
            }
        }

        private void txtNursesFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbNursesFilterBy.Text)
            {
                case "ID":
                    FilterColumn = "ID";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Phone Number":
                    FilterColumn = "PhoneNumber";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtNursesFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtNurses.DefaultView.RowFilter = "";
            }
            else
            {
                _dtNurses.DefaultView.RowFilter = $"Convert({FilterColumn}, 'System.String') like '%{txtNursesFilterBy.Text.Trim()}%'";
            }
        }

        private void cbDoctorsFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDoctorsFilterBy.Visible = (cbDoctorsFilterBy.Text != "None");

            if (txtDoctorsFilterBy.Visible)
            {
                txtDoctorsFilterBy.Text = "";
                txtDoctorsFilterBy.Focus();
            }
        }

        private void txtDoctorsFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbDoctorsFilterBy.Text)
            {
                case "ID":
                    FilterColumn = "ID";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Phone Number":
                    FilterColumn = "PhoneNumber";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtDoctorsFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDoctors.DefaultView.RowFilter = "";
            }
            else
            {
                _dtDoctors.DefaultView.RowFilter = $"Convert({FilterColumn}, 'System.String') like '%{txtDoctorsFilterBy.Text.Trim()}%'";
            }
        }

        private void cbUsersFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsersFilterBy.Visible = (cbUsersFilterBy.Text != "None");

            if (txtUsersFilterBy.Visible)
            {
                txtUsersFilterBy.Text = "";
                txtUsersFilterBy.Focus();
            }
        }

        private void txtUsersFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbUsersFilterBy.Text)
            {
                case "ID":
                    FilterColumn = "ID";
                    break;

                case "User Name":
                    FilterColumn = "UserName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtUsersFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = $"Convert({FilterColumn}, 'System.String') like '%{txtUsersFilterBy.Text.Trim()}%'";
            }
        }

        private void tsmiPatientEdit_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            frmAddEditPatient frm = new frmAddEditPatient(PatientID);
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void tsmiPatientDelete_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete Patient [" + PatientID + "]", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPatient.DeletePatient(PatientID))
                {
                    MessageBox.Show("Patient Deleted Successfully!");
                    _LoadDataForSelectedTabInHome();
                }
                else
                {
                    MessageBox.Show("Patient Was Not Deleted!");
                }
            }
        }

        private void tsmiNurseEdit_Click(object sender, EventArgs e)
        {
            int NurseID = (int)dgvNurses.CurrentRow.Cells[0].Value;
            frmAddEditNurse frm = new frmAddEditNurse(NurseID);
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                frm.RemoveSalaryDetails();
            }
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void tsmiNurseDelete_Click(object sender, EventArgs e)
        {
            int NurseID = (int)dgvNurses.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete Nurse [" + NurseID + "]", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsNurse.DeleteNurse(NurseID))
                {
                    MessageBox.Show("Nurse Deleted Successfully!");
                    _LoadDataForSelectedTabInHome();
                }
                else
                {
                    MessageBox.Show("Nurse Was Not Deleted!");
                }
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddEditPatient frm = new frmAddEditPatient();
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void btnAddNurse_Click(object sender, EventArgs e)
        {
            frmAddEditNurse frm = new frmAddEditNurse();
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                frm.RemoveSalaryDetails();
            }
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void tsmiDoctorEdit_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;
            frmAddEditDoctor frm = new frmAddEditDoctor(DoctorID);
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                frm.RemoveSalaryDetails();
            }
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void tsmiDoctorDelete_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete Doctor [" + DoctorID + "]", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsDoctor.DeleteDoctor(DoctorID))
                {
                    MessageBox.Show("Doctor Deleted Successfully!");
                    _LoadDataForSelectedTabInHome();
                }
                else
                {
                    MessageBox.Show("Doctor Was Not Deleted!");
                }
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            frmAddEditDoctor frm = new frmAddEditDoctor();
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                frm.RemoveSalaryDetails(); 
            }
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void tsmiUserEdit_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmAddEditUser frm = new frmAddEditUser(UserID);
            frm.ShowDialog();
            _LoadDataForSelectedTabInSettings();
        }

        private void tsmiUserDelete_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (clsUser.FindByUserID(UserID).UserName.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Cannot delete user, User Is Admin.", "User is Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are You Sure You Want To Delete User [" + UserID + "]", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show("User Deleted Successfully!");
                    _LoadDataForSelectedTabInSettings();
                }
                else
                {
                    MessageBox.Show("User Was Not Deleted!");
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            _LoadDataForSelectedTabInSettings();
        }

        private void tsmiPatientShowDetails_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            frmPatientDetails frm = new frmPatientDetails(PatientID);
            frm.ShowDialog();
        }

        private void tsmiNurseShowDetails_Click(object sender, EventArgs e)
        {
            int NurseID = (int)dgvNurses.CurrentRow.Cells[0].Value;
            frmNurseDetails frm = new frmNurseDetails(NurseID);
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                frm.RemoveSalaryDetails();
            }
            frm.ShowDialog();
        }

        private void tsmiDoctorShowDetails_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;
            frmDoctorDetails frm = new frmDoctorDetails(DoctorID);
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                frm.RemoveSalaryDetails();
            }
            frm.ShowDialog();
        }

        private void tsmiUserShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmUserDetails frm = new frmUserDetails(UserID);
            frm.ShowDialog();
        }

        private void cbServicesFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServicesFilterBy.Visible = (cbServicesFilterBy.Text != "None");

            if (txtServicesFilterBy.Visible)
            {
                txtServicesFilterBy.Text = "";
                txtServicesFilterBy.Focus();
            }
        }

        private void txtServicesFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbServicesFilterBy.Text)
            {
                case "ID":
                    FilterColumn = "ID";
                    break;

                case "Name":
                    FilterColumn = "Name";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtServicesFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtServices.DefaultView.RowFilter = "";
            }
            else
            {
                _dtServices.DefaultView.RowFilter = $"Convert({FilterColumn}, 'System.String') like '%{txtServicesFilterBy.Text.Trim()}%'";
            }
        }

        private void tsmiServiceEdit_Click(object sender, EventArgs e)
        {
            int ServiceID = (int)dgvServices.CurrentRow.Cells[0].Value;
            frmAddEditService frm = new frmAddEditService(ServiceID);
            frm.ShowDialog();
            _LoadDataForSelectedTabInSettings();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmAddEditService frm = new frmAddEditService();
            frm.ShowDialog();
            _LoadDataForSelectedTabInSettings();
        }

        private void tsmiServiceDelete_Click(object sender, EventArgs e)
        {
            int ServiceID = (int)dgvServices.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete Service [" + ServiceID + "]", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsService.DeleteService(ServiceID))
                {
                    MessageBox.Show("Service Deleted Successfully!");
                    _LoadDataForSelectedTabInSettings();
                }
                else
                {
                    MessageBox.Show("Service Was Not Deleted!");
                }
            }
        }

        private void tsmiServiceShowDetails_Click(object sender, EventArgs e)
        {
            int ServiceID = (int)dgvServices.CurrentRow.Cells[0].Value;
            frmServiceDetails frm = new frmServiceDetails(ServiceID);
            frm.ShowDialog();
        }

        private void btnAddPatientService_Click(object sender, EventArgs e)
        {
            frmAddEditPatientService frm = new frmAddEditPatientService();
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void tsmiPatientServiceEdit_Click(object sender, EventArgs e)
        {
            int PatientServiceID = (int)dgvPatientServices.CurrentRow.Cells[0].Value;
            frmAddEditPatientService frm = new frmAddEditPatientService(PatientServiceID);
            frm.ShowDialog();
            _LoadDataForSelectedTabInHome();
        }

        private void tsmiShowPatientDetails_Click(object sender, EventArgs e)
        {
            int PatientServiceID = (int)dgvPatientServices.CurrentRow.Cells[0].Value;
            clsPatientService PatientService = clsPatientService.FindByPatientServiceID(PatientServiceID);
            frmPatientDetails frm = new frmPatientDetails(PatientService.PatientID);
            frm.ShowDialog();
        }

        private void tsmiShowNurseDetails_Click(object sender, EventArgs e)
        {
            int PatientServiceID = (int)dgvPatientServices.CurrentRow.Cells[0].Value;
            clsPatientService PatientService = clsPatientService.FindByPatientServiceID(PatientServiceID);
            frmNurseDetails frm = new frmNurseDetails(PatientService.NurseID);
            frm.ShowDialog();
        }

        private void tsmiShowDoctorDetails_Click(object sender, EventArgs e)
        {
            int PatientServiceID = (int)dgvPatientServices.CurrentRow.Cells[0].Value;
            clsPatientService PatientService = clsPatientService.FindByPatientServiceID(PatientServiceID);
            frmDoctorDetails frm = new frmDoctorDetails(PatientService.DoctorID);
            frm.ShowDialog();
        }

        private void cbPatientServiceFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPatientServiceFilterBy.Visible = (cbPatientServiceFilterBy.Text != "None");

            if (txtPatientServiceFilterBy.Visible)
            {
                txtPatientServiceFilterBy.Text = "";
                txtPatientServiceFilterBy.Focus();
            }
        }

        private void txtPatientServiceFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbPatientServiceFilterBy.Text)
            {
                case "ID":
                    FilterColumn = "ID";
                    break;

                case "Patient First Name":
                    FilterColumn = "PatientFirstName";
                    break;

                case "Patient Last Name":
                    FilterColumn = "PatientLastName";
                    break;

                case "Nurse First Name":
                    FilterColumn = "NurseFirstName";
                    break;

                case "Doctor First Name":
                    FilterColumn = "DoctorFirstName";
                    break;

                case "Application Date":
                    FilterColumn = "ApplicationDate";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtPatientServiceFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPatientServices.DefaultView.RowFilter = "";
            }
            else
            {
                _dtPatientServices.DefaultView.RowFilter = $"Convert({FilterColumn}, 'System.String') like '%{txtPatientServiceFilterBy.Text.Trim()}%'";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblAmountPaid.Text = clsPatientService.GetAmountPaidForMonth(Convert.ToInt32(cbYear.Text), Convert.ToInt32(cbMonth.Text)).ToString() + " $";
        }

        private void lblCollect_Click(object sender, EventArgs e)
        {
            int TotalAmountPaid = clsPatientService.GetAllAmountPaid();
            if (MessageBox.Show("Are you sure you want to collect the money", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!clsPatientService.UpdateCollectedMoney(TotalAmountPaid))
                {
                    MessageBox.Show("Faild to update collected money.", "Faild to collect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblMoneyToCollect.Text = "0 $";
                    MessageBox.Show("Money is collected successfully!", "Collected Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                

        }

        private void tsmiPatientServiceShowDetails_Click(object sender, EventArgs e)
        {
            int PatientServiceID = (int)dgvPatientServices.CurrentRow.Cells[0].Value;
            frmPatientServiceDetails frm = new frmPatientServiceDetails(PatientServiceID);
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");

            PowerStatus powerStatus = SystemInformation.PowerStatus;
            float batteryPercentage = powerStatus.BatteryLifePercent * 100; 
            bool isCharging = powerStatus.PowerLineStatus == PowerLineStatus.Online; 

            lblBattery.Text = $"Battery: {batteryPercentage}% ";
            lblStatus.Text = $"{(isCharging ? "(Charging)" : "(On Battery)")}";
        }

     

        private void tsmiPatientServiceDelete_Click(object sender, EventArgs e)
        {
            int PatientServiceID = (int)dgvPatientServices.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are You Sure You Want To Delete Patient Service [" + PatientServiceID + "]", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPatientService.DeletePatientService(PatientServiceID))
                {
                    MessageBox.Show("Deleted Successfully!");
                    _LoadDataForSelectedTabInHome();
                }
                else
                {
                    MessageBox.Show("Not Deleted Sucessfully!");
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int PatientServiceID = (int)dgvPatientServices.CurrentRow.Cells[0].Value;

            clsPatientService _PatientService = clsPatientService.FindByPatientServiceID(PatientServiceID);
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font font = new Font("Arial", 12);
            float startX = 30; // Further reduced left margin
            float startY = 10;
            float offsetY = 25; // Spacing between lines


            Image logo = Properties.Resources.Screenshot_2024_08_22_224826_1;
            Image qr = Properties.Resources.bing_generated_qrcode;

            // Draw the QR code at the top-right corner with a larger size
            e.Graphics.DrawImage(qr, e.PageBounds.Width - 160 - 20, startY, 150, 150); // Adjusted position to move left

            // Print the hospital name and invoice title on the left
            string headerText = "Al Ahmad Nurse Care";
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, startX, startY + 30); // Moved upward slightly
            offsetY += 60;

            // Draw the larger logo centered on the page, slightly adjusted upward
            float centerXForLogo = (e.PageBounds.Width - 200) / 2; // Center the larger logo
            e.Graphics.DrawImage(logo, centerXForLogo, startY + offsetY - 50, 250, 200); // Larger logo size for centering, moved upward
            offsetY += 170; // Adjust offset for space below the centered logo

            // Print PatientService ID, Patient ID, and Patient Name
            string patientName = $"{_PatientService.Patient.FirstName} {_PatientService.Patient.SecondName} {_PatientService.Patient.LastName}";
            e.Graphics.DrawString($"Bill ID: {_PatientService.ID}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;
            e.Graphics.DrawString($"Patient ID: {_PatientService.PatientID} - Name: {patientName}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;

            // Check if NurseID is not -1 and print it with the Nurse's name
            if (clsNurse.FindByNurseID(_PatientService.NurseID) != null)
            {
                string nurseName = $"{_PatientService.Nurse.FirstName} {_PatientService.Nurse.LastName}";
                e.Graphics.DrawString($"Nurse ID: {_PatientService.NurseID} - Name: {nurseName}", font, Brushes.Black, startX, startY + offsetY);
                offsetY += 25;
            }

            // Check if DoctorID is not -1 and print it with the Doctor's name
            if (clsDoctor.FindByDoctorID(_PatientService.DoctorID) != null)
            {
                string doctorName = $"{_PatientService.Doctor.FirstName} {_PatientService.Doctor.LastName}";
                e.Graphics.DrawString($"Doctor ID: {_PatientService.DoctorID} - Name: {doctorName}", font, Brushes.Black, startX, startY + offsetY);
                offsetY += 25;
            }

            // Print Application Request after Nurse ID
            e.Graphics.DrawString($"Application Request: {_PatientService.ApplicationRequest}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;

            // Print Application Date below the IDs
            e.Graphics.DrawString($"Application Date: {_PatientService.ApplicationDate:dd-MM-yyyy}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;

            // Print Starting Date after the Application Date
            e.Graphics.DrawString($"Starting Date: {_PatientService.StartingDate:dd-MM-yyyy}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 40; // Add extra space before the table

            // Draw table headers for services, service prices, and other properties
            e.Graphics.DrawString("Services", font, Brushes.Black, startX, startY + offsetY);
            e.Graphics.DrawString("Service Price", font, Brushes.Black, startX + 180, startY + offsetY); // Adjusted position
            e.Graphics.DrawString("Amount Paid", font, Brushes.Black, startX + 320, startY + offsetY); // Increased spacing
            e.Graphics.DrawString("Total Amount", font, Brushes.Black, startX + 450, startY + offsetY); // Increased spacing
            e.Graphics.DrawString("Amount Remaining", font, Brushes.Black, startX + 580, startY + offsetY); // Increased spacing
            offsetY += 25;

            // Draw a line under the headers, extended slightly to the left and right
            e.Graphics.DrawLine(Pens.Black, startX - 10, startY + offsetY, startX + 740, startY + offsetY); // Adjusted line position to move right
            offsetY += 5;

            // Split services and calculate amounts
            string[] services = _PatientService.Services.Split(',');
            decimal totalAmount = _PatientService.TotalAmount;
            decimal amountPaid = _PatientService.AmountPaid;
            decimal amountRemaining = totalAmount - amountPaid;
            float serviceY = offsetY;

            // Print each service, its price, and display amount values only in the first row
            for (int i = 0; i < services.Length; i++)
            {
                string trimmedService = services[i].Trim();
                var servicePrice = clsService.FindByServiceName(trimmedService).SalePrice;

                e.Graphics.DrawString(trimmedService, font, Brushes.Black, startX, startY + serviceY);
                e.Graphics.DrawString($"${servicePrice}", font, Brushes.Black, startX + 180, startY + serviceY); // Adjusted position

                // Print the amount values only for the first service row
                if (i == 0)
                {
                    e.Graphics.DrawString($"${amountPaid}", font, Brushes.Black, startX + 320, startY + serviceY); // Adjusted position for more spacing
                    e.Graphics.DrawString($"${totalAmount}", font, Brushes.Black, startX + 450, startY + serviceY); // Adjusted position for more spacing
                    e.Graphics.DrawString($"${amountRemaining}", font, Brushes.Black, startX + 580, startY + serviceY); // Adjusted position for more spacing
                }

                serviceY += 20;
            }

            // Draw a line under the last service row, extended slightly to the left and right
            e.Graphics.DrawLine(Pens.Black, startX - 10, startY + serviceY, startX + 740, startY + serviceY); // Adjusted line position to move right
            offsetY += serviceY - offsetY + 30; // Add space before the additional details

            // Print the additional properties after the table, positioning them lower
            e.Graphics.DrawString($"Period: {_PatientService.Period}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;
            e.Graphics.DrawString($"Shift: {_PatientService.Shift}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;
            e.Graphics.DrawString($"Equipments Needed: {_PatientService.EquipmentsNeeded}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;
            e.Graphics.DrawString($"Patient Diagnostic: {_PatientService.PatientDiagnostic}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 25;
            e.Graphics.DrawString($"Hospital Name: {_PatientService.HospitalName}", font, Brushes.Black, startX, startY + offsetY);
            offsetY += 40; // Add space before the signature

            // Print Signature placeholder without box, positioned lower
            e.Graphics.DrawString("Signature: ____________________", font, Brushes.Black, startX, startY + offsetY + 40); // Moved down further
            e.Graphics.DrawString("info@alahmadnursecare.com", font, Brushes.Black, startX, startY + offsetY + 115); // Moved down further
            e.Graphics.DrawString("71304006", font, Brushes.Black, startX, startY + offsetY + 140); // Moved down further
            e.Graphics.DrawString("03141300", font, Brushes.Black, startX, startY + offsetY + 165); // Moved down further





        }


        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument1;

                // Show the print dialog
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the paper size to A4
                    printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // A4 size in hundredths of millimeters

                    // Print the document
                    printDocument1.Print();
                }
            }
        }

    }
}
