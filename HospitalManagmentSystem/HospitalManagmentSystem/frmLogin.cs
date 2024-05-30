using HMS_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagmentSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private bool ValidateDocName(string DocName)
        {

            if (clsDoctors.CheckDoctorName(DocName))
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        private bool ValidateDocPassword(string DocPassword)
        {

            if (clsDoctors.CheckDoctorPassword(DocPassword))
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtDoctorName.Text == string.Empty)
            {
                MessageBox.Show("Enter valid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtDoctorPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateDocName(txtDoctorName.Text.Trim()))
            {
                MessageBox.Show("DoctorName is Wrong","Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!ValidateDocPassword(txtDoctorPassword.Text.Trim()))
            {
                MessageBox.Show("Password is Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmHome Home = new frmHome();

            Home.ShowDialog();
            this.Close();

        }

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDoctorName.Text = "";
            txtDoctorPassword.Text = "";

        }
    }
}
