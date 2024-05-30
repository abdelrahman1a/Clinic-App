using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HospitalManagmentSystem
{
    public partial class ctrlDiagnosisPatient : UserControl
    {
        public int PatientID { get; set; }  
        public string PatientName { get; set; } 
        public string Symptoms { get; set; }    
        public string Diagnosis { get ; set; }  
        public string Medicine { get; set; }    

        public ctrlDiagnosisPatient()
        {
            InitializeComponent();
            PatientID = -1;
            PatientName = "";
            Symptoms = "";
            Diagnosis = "";
            Medicine = "";

      
        }

        public  void fillcntrlData()
        {
            lblPatientID.Text = PatientID.ToString();
            lblPatientName.Text = PatientName.ToString();
            lblSymptoms.Text = Symptoms.ToString();
            lblDiagnosis.Text = Diagnosis.ToString();
            lblMedicine.Text = Medicine.ToString();
        }
        public void ResetData()
        {
            lblPatientID.Text = PatientID.ToString();
            lblPatientName.Text = PatientName.ToString();
            lblSymptoms.Text = "???";
            lblDiagnosis.Text = "???";
            lblMedicine.Text = "???";
        }



    }
}
