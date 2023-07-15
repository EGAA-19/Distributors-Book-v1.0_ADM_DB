using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Domain;
using FontAwesome.Sharp;
using System.Runtime.InteropServices; //Para mover la pestana con el cursor
using System.Windows.Forms;


namespace Layout
{
    public partial class frmHome : Form
    {
        //Initializate Form
        private frmDistributorData frmEdit;

        public frmHome()
        {
            InitializeComponent();
            frmEdit = new frmDistributorData();
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadDistributors();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Load Distributors in DataGridView
        private void LoadDistributors()
        {
            UserModel distributor = new UserModel();
            dgvDistributors.AutoGenerateColumns = false;
            dgvDistributors.DataSource = distributor.ListDistributors(txtNameCompany.Text);
        }

        //==> start Action on Form
        private void btnCloseWindows_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinisizeWindows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void frmDistributorData_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDistributors();
        }
        //==> End Action on Form

        /*Start AMD*/

        //Add
        private void btnNewDistributor_Click(object sender, EventArgs e)
        {
            frmDistributorData distributor = new frmDistributorData();
            distributor.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmDistributorData_FormClosed);
            distributor.ShowDialog();
        }
        //Delete
        private void btnDeleteDsitributor_Click(object sender, EventArgs e)
        {
            if (dgvDistributors.SelectedRows.Count > 0)
            {
                int id = (int)dgvDistributors.SelectedRows[0].Cells["Id"].Value;
                DeleteDistributor(id);
            }
            else MessageBox.Show("select a data to execute the action, please", "", MessageBoxButtons.OK);
            
        }
        //Modify
        private void btnEditDistributor_Click(object sender, EventArgs e)
        {
            if (dgvDistributors.SelectedRows.Count > 0)
            {
                int id = (int)dgvDistributors.SelectedRows[0].Cells["Id"].Value;
                frmEditableDistributor(id);
            }
            else MessageBox.Show("select a data to execute the action, please", "distributor", MessageBoxButtons.OK);
        }
        /*End AMD*/

        //Search distriibutors
        private void btnSearchDistributor_Click(object sender, EventArgs e)
        {
            LoadDistributors();
        }
        //methods with resources for AMD
        private void frmEditableDistributor(int id)
        {
            frmDistributorData distributor = new frmDistributorData(id);
            distributor.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmDistributorData_FormClosed);
            distributor.ShowDialog();
        }
        private void DeleteDistributor(int id)
        {
            UserModel distributor = new UserModel();

            if (MessageBox.Show("¿Are you sure to remove the distributor??", "distributor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                distributor.DeleteDistributor(id);
                MessageBox.Show("The distributor was successfully deleted");
                LoadDistributors();
            }
        }
        //Action on Form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
