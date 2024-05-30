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

namespace HospitalManagmentSystem.frmDiagnosiswithUpdates
{
    public partial class frmDeleteDiagnosis : Form
    {
        public frmDeleteDiagnosis(int PatientID)
        {
            InitializeComponent();
            txtPatientID.Text = PatientID.ToString();   
            txtPatientID.Enabled = false;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure you want to delete this diagnosis?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(clsDiagnosis.DeleteDiagnosis(Convert.ToInt32(txtPatientID.Text)))
                {
                    MessageBox.Show("Patient Deleted Successfully");

                }
                else
                {
                    MessageBox.Show("Check there is An Error");

                }

            }
            else
            {
                MessageBox.Show("There is no Change");
            }


        }
    }
}
