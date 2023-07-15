using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Domain;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;//For move the window with the cursor

namespace Layout
{
    public partial class frmDistributorData : Form
    {
        //Initialize Form
        public frmDistributorData()
        {
            InitializeComponent();
        }

        //For move the window with the cursor
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Instances
        private Common.Entity Distributor = new Common.Entity();
        UserModel dist = new UserModel();

        //get data from the provider and display it in the text boxes of the frmDistributorData
        public frmDistributorData(int Id)
        {
            InitializeComponent();

            Distributor = dist.ObtainDistributor(Id);

            lblId.Text = Convert.ToString(Distributor.Id);
            txtCompany.Text = Distributor.Company;
            txtPhone.Text = Distributor.Phone;
            txtRepresentative.Text = Distributor.Representative;
            txtEmail.Text = Distributor.Email;
            txtCity.Text = Distributor.City;
            txtAdress.Text = Distributor.Adress;
            chbxTransport.Checked = Distributor.Transport;
        }

        //==>Field validation
        private bool ValidatedFields()
        {
            var fields = new List<TextBoxValidation>
            {
                new TextBoxValidation(txtCompany, "Company Name"),
                new TextBoxValidation(txtPhone, "Phone Number"),
                new TextBoxValidation(txtRepresentative, "Representante Name"),
                new TextBoxValidation(txtEmail, "Email Adress"),
                new TextBoxValidation(txtCity, "City"),
                new TextBoxValidation(txtAdress, "Adress"),
            };
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.TextBox.Text))
                {
                    ShowError(string.Format("You must enter {0}.", field.NameField));
                    return false;
                }
            }

            return true;
        }
        //Resource for Validation
        private class TextBoxValidation
        {
            public TextBox TextBox { get; set; }
            public string NameField { get; set; }

            public TextBoxValidation(TextBox textBox, string nameField)
            {
                TextBox = textBox;
                NameField = nameField;
            }
        }
        //Message Error
        private void ShowError(string mensaje)
        {
            MessageBox.Show(mensaje, "validation error");
        }
        //==>Field validation

        //==>Action Buttons
        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Acept
        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (!ValidatedFields())
            {
                MessageBox.Show("Enter all required fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Distributor.Company = txtCompany.Text;
            Distributor.Phone = txtPhone.Text;
            Distributor.Representative = txtRepresentative.Text;
            Distributor.Email = txtEmail.Text;
            Distributor.City = txtCity.Text;
            Distributor.Adress = txtAdress.Text;
            Distributor.Transport = chbxTransport.Checked;

            dist.UploadDistributor(Distributor);

            MessageBox.Show("Employee saved successfully");
            this.Close();   
        }
        //==>Field validation

        //Action on Form
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}