using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_DataAccess;

namespace HMS_Buisness
{
    public class clsDoctors
    {
        public enum enMode {AddNew = 0 , Update =1 }
        private enMode _Mode = enMode.AddNew;
        
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }  
        public int DocExp { get; set; }

        public string DoctorPassword { get; set; }
        public string DoctorSpecialization { get; set; }

        public clsDoctors()
        {
            this.DoctorID = -1;
            this.DoctorName = "";
            this.DocExp = 0;
            this.DoctorPassword = "";
            this.DoctorSpecialization = "";
            _Mode = enMode.AddNew;
        }
        public clsDoctors(int DoctorID , string DoctorName , int DocExp , string Password , string DoctorSpecialization)
        {
            this.DoctorID = DoctorID;
            this.DoctorName = DoctorName;
            this.DocExp = DocExp;
            this.DoctorPassword = Password;
            this.DoctorSpecialization = DoctorSpecialization;   
            _Mode = enMode.Update;
        }

        private bool _AddNewDoctor()
        {
            this.DoctorID = clsDoctorsData.AddNewDoctor(this.DoctorName, this.DocExp, this.DoctorPassword , this.DoctorSpecialization);

            return (this.DoctorID != -1) ;
        }
        private bool _UpdateDoctor()
        {

            return clsDoctorsData.UpdateDoctor(this.DoctorID , this.DoctorName, this.DocExp, this.DoctorPassword , this.DoctorSpecialization);

        }

        public static clsDoctors GetDoctorInfoByID(int DoctorID) 
        {
            string DoctorName = "", DoctorPassword = "" , DoctorSpecialization = "";
            int DocExp = 0;
            clsDoctorsData.Find(DoctorID, ref DoctorName, ref DocExp, ref DoctorPassword ,ref DoctorSpecialization);

            return new clsDoctors(DoctorID , DoctorName , DocExp , DoctorPassword , DoctorSpecialization); 
        }
        public static bool Delete(int DocID)
        {
            return clsDoctorsData.DeleteDoctor(DocID);
        }
        public static DataTable GetAllDoctors()
        {
            return clsDoctorsData.GetAllDoctors();
        }

        public static bool CheckDoctorName(string DocName)
        {
            return clsDoctorsData.CheckDoctorName(DocName);
        }

        public static bool CheckDoctorPassword(string DocPassword)
        {
            return clsDoctorsData.CheckDoctorPassword(DocPassword);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDoctor())
                    {
                        return true;
                    }
                    else 
                        return false;
                case enMode.Update:
                    if (_UpdateDoctor())
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
