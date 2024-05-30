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
    public partial class ctrlAddUpdateDiagnosis : UserControl
    {
        public string Title
        {
            get {return lblTitle.Text; }
            set { lblTitle.Text = value; }

        }
        public int PatId { get; set; }
        public string PatName { get; set; } 
        // for AddNew
        public ctrlAddUpdateDiagnosis()
        {
            InitializeComponent();
          
          
        }
        
        public bool IsValidated()
        {
            bool isValidated = false;
            if (txtSymptoms.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid Symptoms");
              
                return isValidated;
            }
            else if (txtDiagnosis.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid Diagnosis");
                return isValidated;
            }
            else if (txtMedicines.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid Medicines");
                return isValidated;
            }
          
            isValidated = true;
            return isValidated;

            

        }
        public void FillPatIDandPatName()
        {
            txtPatientID.Text = PatId.ToString();
            txtPatientName.Text = PatName.ToString();   
            txtPatientID.Enabled = false;
            txtPatientName.Enabled = false;

        }

        private void ResetDiagnosis()
        {
            txtDiagnosis.Text = string.Empty;
            txtMedicines.Text = string.Empty;
            txtSymptoms.Text = string.Empty;
        }

        public void SaveAddnewDiagnosis()
        {
            clsDiagnosis addnewdiagnosis = new clsDiagnosis();
            addnewdiagnosis.Symptoms = txtSymptoms.Text;    
            addnewdiagnosis.Medicine = txtMedicines.Text;    
            addnewdiagnosis.Diagnosis = txtDiagnosis.Text;  
            if (clsDiagnosis.CheckSpecificID(Convert.ToInt32(txtPatientID.Text)))
            {
                MessageBox.Show("Patient is Daiagnosed");
                ResetDiagnosis();
                return;
            }
            addnewdiagnosis.PatientID = Convert.ToInt32(txtPatientID.Text);    
            addnewdiagnosis.PatientName = txtPatientName.Text;    

            if(addnewdiagnosis.Save())
            {
                MessageBox.Show("Data Saved Successfully");
                ResetDiagnosis();




            }
            else
            {
                MessageBox.Show("check there is and Error!");

            }
        }

        public void SaveUpdateDiagnosis() {

            clsDiagnosis UpdateDiagnosis = new clsDiagnosis(Convert.ToInt32(txtPatientID.Text) , txtSymptoms.Text , txtDiagnosis.Text , txtMedicines.Text );

            if (UpdateDiagnosis.Save())
            {
                MessageBox.Show("Data Updated Successfully");
                ResetDiagnosis();
            }
            else
            {
                MessageBox.Show("check there is and Error!");

            }

        }
        private void txtSymptoms_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
