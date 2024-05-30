using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_Buisness;
using HospitalManagmentSystem.frmDiagnosiswithUpdates;

namespace HospitalManagmentSystem
{
    public partial class frmDiagnosis : Form
    {
        private int selectedID;
        private DataTable _AllDiagnosisPatientData;
        private string PatientName = "";
        public frmDiagnosis()
        {
            InitializeComponent();
            ctrlDiagnosisPatient1.PatientID = 1;



        }
        private void AddIdstoComboBox()
        {
            List<int> ids = clsDiagnosis.fillComboBoxWithID();
            foreach (int id in ids)
            {
                cbPatientIDs.Items.Add(id);
            }
        }
        private void frmDiagnosis_Load(object sender, EventArgs e)
        {
            if(!(cbPatientIDs.Items.Count > 0)) // check if the combobox has items or not
            AddIdstoComboBox();
            _AllDiagnosisPatientData = clsDiagnosis.GetAllData();
            dgvDiagnosisPatientList.DataSource = _AllDiagnosisPatientData;

            if (dgvDiagnosisPatientList.Rows.Count > 0)
            {
                dgvDiagnosisPatientList.Columns[0].HeaderText = "DiagnosisID";
                dgvDiagnosisPatientList.Columns[0].Width = 100;

                dgvDiagnosisPatientList.Columns[1].HeaderText = "PatientID";
                dgvDiagnosisPatientList.Columns[1].Width = 100;

                dgvDiagnosisPatientList.Columns[2].HeaderText = "Symptoms";
                dgvDiagnosisPatientList.Columns[2].Width = 320;

                dgvDiagnosisPatientList.Columns[3].HeaderText = "Diagnosis";
                dgvDiagnosisPatientList.Columns[3].Width = 200;

                dgvDiagnosisPatientList.Columns[4].HeaderText = "Medicines";
                dgvDiagnosisPatientList.Columns[4].Width = 200;

                dgvDiagnosisPatientList.Columns[5].HeaderText = "Patient Name";
                dgvDiagnosisPatientList.Columns[5].Width = 150;
            }

        }

        private void llbPatientForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatient frm = new frmPatient();
            frm.ShowDialog();
        }

        private void cbPatientIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedID = (int)cbPatientIDs.SelectedItem;
            List<string> selectedDiagnosisData = clsDiagnosis.GetSpecificRow(selectedID);
            ctrlDiagnosisPatient1.PatientID = selectedID;
            ctrlDiagnosisPatient1.PatientName = clsPatients.GetPatientName(selectedID);


            if (selectedDiagnosisData.Count > 0)
            {
                ctrlDiagnosisPatient1.Symptoms = selectedDiagnosisData[0];
                ctrlDiagnosisPatient1.Diagnosis = selectedDiagnosisData[1];
                ctrlDiagnosisPatient1.Medicine = selectedDiagnosisData[2];
                ctrlDiagnosisPatient1.PatientName = selectedDiagnosisData[3];


                ctrlDiagnosisPatient1.fillcntrlData();

            }
            else
            {
                ctrlDiagnosisPatient1.ResetData();

                MessageBox.Show("Patient Not Diagnosis yet");
            }


        }



        private bool IsPatientDiagnosed()
        {
            bool IsDiagnosed = false; // Initialize the variable to store the patient name

            // Loop through each row in the DataTable
            foreach (DataRow row in _AllDiagnosisPatientData.Rows)
            {
                // Check if the "ID" column exists in the DataTable
                if (_AllDiagnosisPatientData.Columns.Contains("PatientID") && Convert.ToInt32(row["PatientID"]) == selectedID)
                {
                    IsDiagnosed = true;
                    break;
                }
            }

            return IsDiagnosed; // Return the patient name

        }
        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            PatientName = clsPatients.GetPatientName(selectedID);
            if (cbPatientIDs.SelectedIndex != -1)
            {
                if (!IsPatientDiagnosed())
                {
                    frmAddNewDiagnosis frm = new frmAddNewDiagnosis(selectedID, PatientName);
                    frm.ShowDialog();
                    frmDiagnosis_Load(null, null);
                }
                else
                {
                    MessageBox.Show("The Patient is Diagnosed");
                }

            }
            else
            {
                MessageBox.Show("Please Select an ID from Patient ID to do Diagnosis ");
            }

        }

        private void btnUpdateDiagnosis_Click(object sender, EventArgs e)
        {
            PatientName = clsPatients.GetPatientName(selectedID);
            if (cbPatientIDs.SelectedIndex != -1)
            {

                frmUpdateDiagnosis frm = new frmUpdateDiagnosis(selectedID ,PatientName );
                frm.ShowDialog();
                frmDiagnosis_Load(null, null);

            }
            else
            {
                MessageBox.Show("Please Select an ID from Patient ID to do Diagnosis ");
            }


        }

        private void btnDeleteDiagnosis_Click(object sender, EventArgs e)
        {
         
            if (cbPatientIDs.SelectedIndex != -1)
            {

                frmDeleteDiagnosis frm = new frmDeleteDiagnosis(selectedID);
                frm.ShowDialog();
                frmDiagnosis_Load(null, null);

            }
            else
            {
                MessageBox.Show("Please Select an ID from Patient ID to do Diagnosis ");
            }
        }
    }
}
