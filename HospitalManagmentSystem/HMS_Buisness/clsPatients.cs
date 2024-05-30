using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_DataAccess;

namespace HMS_Buisness
{
    public class clsPatients
    {
        public enum enMode { AddNew , Update}
        enMode _Mode = enMode.AddNew;   

        int PatID { set; get; } 
        public string PatName { set; get; } 
        public string PatAddress { set; get; } 
        public int PatAge { set; get; }

        public string PatGender { set; get; }

        public string PatDisease { set; get; }
        public string BloodGroup { set; get; }

        public clsPatients()
        {
            PatID = -1;
            PatAge = -1;
            PatName = "";
            PatAddress = "";
            PatGender = "";
            PatDisease = "";
            BloodGroup = "";

            _Mode = enMode.AddNew;
        }
        public clsPatients(int patID , string patName, string patAddress, int PatAge , string PatGender, string PatDisease , string BloodGroup)
        {
            this.PatID = patID;
            this.PatName = patName;
            this.PatAddress = patAddress;
            this.PatGender = PatGender;
            this.PatAge = PatAge;
            this.PatDisease = PatDisease;
            this.BloodGroup = BloodGroup;


            _Mode = enMode.Update;
        }

        private bool _AddNewPatient()
        {
            this.PatID =  clsPatientsData.AddNewpatient(this.PatName, this.PatAddress, this.PatAge,this.PatGender ,this.PatDisease , this.BloodGroup);   
            return (this.PatID != -1); 
        }

        private bool _UpdatePatient()
        {
            return clsPatientsData.UpdatePatient(this.PatID,this.PatName, this.PatAddress, this.PatAge, this.PatGender, this.PatDisease, this.BloodGroup);
            
        }
        public static DataTable GetAllPatients()
        {
            return clsPatientsData.GetAllPaients();
        }
        public static bool DeletePatient(int patID) 
        {
             return  clsPatientsData.DeletePatient(patID);
        }
        public static string GetPatientName(int ID)
        {
            return clsPatientsData.GetPatientName(ID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePatient();

            }

            return false;
        }

    }
}
