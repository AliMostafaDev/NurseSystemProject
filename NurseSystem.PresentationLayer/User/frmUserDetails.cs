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
    public partial class frmUserDetails : Form
    {
        private int _ID;
        private clsUser _User;

        public frmUserDetails(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            _User = clsUser.FindByUserID(_ID);

            if (_User == null)
            {
                MessageBox.Show("No User With ID = " + _ID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = "[" + _User.ID.ToString() + "]";
            lblUserName.Text = _User.UserName;
            lblPassword.Text = _User.Password;
            lblIsAdmin.Text = _User.IsAdmin ? "Yes" : "No";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
