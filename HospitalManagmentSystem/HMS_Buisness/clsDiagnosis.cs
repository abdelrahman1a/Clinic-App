using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using HMS_DataAccess;
namespace HMS_Buisness
{
    public class clsDiagnosis : clsPatients
    {
        private enum enMode { AddNew = 0 , Update = 1 } 
        enMode _Mode = enMode.AddNew;
        public int DiagnosisID { get; set; }    
        public int PatientID { get; set; }    
        public string Symptoms { get; set; }    
        public string Diagnosis { get; set; }   
        public string Medicine { get; set; }   
        public string PatientName { get; set; }

        public clsDiagnosis()
        {
            DiagnosisID = -1;
            Symptoms = "";
            Diagnosis = "";
            Medicine = "";
            PatientName = "";
            _Mode = enMode.AddNew ;
        }
        public clsDiagnosis(int PatientID , string Symptoms , string Diagnosis , string Medicine )
        {
            this.Symptoms = Symptoms;
            this.Diagnosis = Diagnosis; 
            this.Medicine = Medicine;
            this.PatientID = PatientID;
            _Mode = enMode.Update;

        }
        private bool _AddNewDiagnosis()
        {
            return clsDiagnosisData.AddNewDiagnosis(this.PatientID,this.Symptoms , this.Diagnosis , this.Medicine, this.PatientName);
        }
        private bool _UpdateDiagnosis() {
            return clsDiagnosisData.UpdateDiagnosis(this.PatientID , this.Symptoms , this.Diagnosis , this.Medicine );
        }

        public static DataTable GetAllData()
        {
           return  clsDiagnosisData.GetAllDiagnosis();
        }

        public static List<int> fillComboBoxWithID()
        {
             return  clsDiagnosisData.FillComboBoxWithID();
        }

        public static List<string> GetSpecificRow(int ID)
        {
           return clsDiagnosisData.GetSpecificRowofData(ID);
        }

        public static bool CheckSpecificID(int ID)
        {
            return clsDiagnosisData.CheckSpecificID(ID);
        }

        public static bool DeleteDiagnosis(int PatientID)
        {
            return clsDiagnosisData.DeleteDiagnosis(PatientID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDiagnosis())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    if (_UpdateDiagnosis())
                    {
                        return true;
                    }
                    else
                        return false;
            }
            return false;
        }

    }
}
