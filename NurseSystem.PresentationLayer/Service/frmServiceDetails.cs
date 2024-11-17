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
    public partial class frmServiceDetails : Form
    {
        private int _ID;
        private clsService _Service;

        public frmServiceDetails(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void frmServiceDetails_Load(object sender, EventArgs e)
        {
            _Service = clsService.FindByServiceID(_ID);

            if (_Service == null)
            {
                MessageBox.Show("No Service With ID = " + _ID, "Service Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblID.Text = "[" + _Service.ID.ToString() + "]";
            lblBasicPrice.Text = _Service.BasicPrice.ToString() + " $";
            lblServiceName.Text = _Service.Name;
            lblSalePrice.Text = _Service.SalePrice.ToString() + " $";
            lblDescription.Text = _Service.Description;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
