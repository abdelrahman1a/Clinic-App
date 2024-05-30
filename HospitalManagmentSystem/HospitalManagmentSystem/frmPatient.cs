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
using System.Text.RegularExpressions;


namespace HospitalManagmentSystem
{
    public partial class frmPatient : Form
    {

        private static DataTable _dtAllPatients;
        public frmPatient()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.ShowDialog();

        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            rbAddNewPatient.Checked = true;
            _dtAllPatients = clsPatients.GetAllPatients();
            dgvPatients.DataSource = _dtAllPatients;
            cbBloodGroup.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;

            if (dgvPatients.Rows.Count > 0)
            {
                dgvPatients.Columns[0].HeaderText = "Patient ID";
                dgvPatients.Columns[0].Width = 100;

                dgvPatients.Columns[1].HeaderText = "Patient Name";
                dgvPatients.Columns[1].Width = 220;

                dgvPatients.Columns[2].HeaderText = "Patient Address";
                dgvPatients.Columns[2].Width = 250;

                dgvPatients.Columns[3].HeaderText = "Patient Age";
                dgvPatients.Columns[3].Width = 100;

                dgvPatients.Columns[4].HeaderText = "Patient Gender";
                dgvPatients.Columns[4].Width = 100;

                dgvPatients.Columns[5].HeaderText = "Patient Disease";
                dgvPatients.Columns[5].Width = 200;


                dgvPatients.Columns[6].HeaderText = "BloodGroup";
                dgvPatients.Columns[6].Width = 300;
            }
        }

        private void ResetInputs()
        {
            lblPatientID.Text = "Patient ID";
            lblPatientAge.Text = "Patient Age";
            lblPatientAddress.Text = "PatientAddress";
            lblPatientName.Text = "PatientName";
            cbBloodGroup.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;

            // Reset Error Provider
          

        }
        private void rbAddNewPatient_CheckedChanged(object sender, EventArgs e)
        {

            lblPatientID.Enabled = false;
            lblPatientAddress.Enabled = true;
            lblPatientAge.Enabled = true;
            lblPatientName.Enabled = true;
            cbBloodGroup.Enabled = true;
            cbGender.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void rbDeletepatient_CheckedChanged(object sender, EventArgs e)
        {
            lblPatientID.Enabled = true;
            lblPatientAddress.Enabled = false;
            lblPatientAge.Enabled = false;
            lblPatientName.Enabled = false;
            cbBloodGroup.Enabled = false;
            cbGender.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void rbUpdatePatient_CheckedChanged(object sender, EventArgs e)
        {
            lblPatientID.Enabled = true;
            lblPatientAddress.Enabled = true;
            lblPatientAge.Enabled = true;
            lblPatientName.Enabled = true;
            cbBloodGroup.Enabled = true;
            cbGender.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
        }
        private bool ValidateUpdatePatient()
        {
            bool isvalidated = true;
            if (lblPatientID.Text == string.Empty || lblPatientID.Text == "Patient ID")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid PatientID");
            }
            else if (lblPatientName.Text == string.Empty || lblPatientName.Text == "PatientName")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Patient Name");
            }
            else if (lblPatientAddress.Text == "PatientAddress" || lblPatientAddress.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid PatientAddress");
            }
            else if (lblPatientAge.Text == "PatientAge" || lblPatientAge.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid PatientAge");
            }

            return isvalidated;
        }
        private bool ValidateDeletePatient() 
        {
            bool isvalidated = true;
            if (lblPatientID.Text == string.Empty || lblPatientID.Text == "Patient ID")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid PatientID");
            }
            

            return isvalidated;
        }
        private bool ValidateAddPatient()
        {
            bool isvalidated = true;
           
            if (lblPatientName.Text == string.Empty || lblPatientName.Text == "PatientName")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Patient Name");
            }
            else if (lblPatientAddress.Text == "PatientAddress" || lblPatientAddress.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid PatientAddress");
            }
            else if (lblPatientAge.Text == "PatientAge" || lblPatientAge.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid PatientAge");
            }

            return isvalidated;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(!ValidateUpdatePatient())
            {
                return;
            }
            int PatientAge = -1;
            int PatientID = -1;
           
                if (int.TryParse(lblPatientID.Text, out int output))
                {
                    PatientID = output;
                }
                else
                {
                    MessageBox.Show("Error in PatientID Enter Valid One");
                    return;
                }
                if (int.TryParse(lblPatientAge.Text, out int Ageout))
                {
                    PatientAge = Ageout;
                }
                else
                {
                    MessageBox.Show("Error in PatientAge Enter Valid One");
                    return;
                }
                clsPatients patUpdate = new clsPatients(PatientID, lblPatientName.Text, lblPatientAddress.Text, PatientAge, cbGender.SelectedItem.ToString(), "Not Implemented Yet", cbBloodGroup.SelectedItem.ToString());
                if (patUpdate.Save())
                {
                    MessageBox.Show("Patient with ID = " + PatientID + " Updated Successfully" ,"Updated" ,  MessageBoxButtons.OK ,MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Error In Update Check if the Inputs is Wrong" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);


                }
            ResetInputs();
            frmPatient_Load(null, null); // for refresh


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(!ValidateAddPatient())
            {
                return;
            }
           
                int PatientAge = -1;
                if (int.TryParse(lblPatientAge.Text.Trim(), out int Ageout))
                {
                    PatientAge = Ageout;
                }
                else
                {
                    MessageBox.Show("Enter Valid Age");
                    return;
                }
                clsPatients addnewpatient = new clsPatients();
                addnewpatient.PatAddress = lblPatientAddress.Text.Trim();
                addnewpatient.PatAge = PatientAge;
                addnewpatient.PatName = lblPatientName.Text.Trim();
                addnewpatient.PatGender = cbGender.SelectedItem.ToString();
                addnewpatient.BloodGroup = cbBloodGroup.SelectedItem.ToString();
                addnewpatient.PatDisease = "NotImpelemented";

                if (addnewpatient.Save())
                {
                    MessageBox.Show("Patient Added Successfully", "AddedSucceeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetInputs();
                    frmPatient_Load(null, null); // for refresh
                }
                else
                {
                    MessageBox.Show("Error In Adding ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!ValidateDeletePatient())
            {
                return;
            }
                int PatientID = -1;
                if (int.TryParse(lblPatientID.Text, out int output))
                {
                    PatientID = output;
                }
                if (clsPatients.DeletePatient(PatientID))
                {
                    MessageBox.Show("Patient Deleted Successfully With ID = " + PatientID, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                 

                }
                else
                {
                    MessageBox.Show("Error In Deleting Check Please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            ResetInputs();
            frmPatient_Load(null, null); // for refresh
          

        }
    }
}
