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
    public partial class frmAddNewDiagnosis : Form
    {
        public frmAddNewDiagnosis(int ID , string PatientName)
        {
            InitializeComponent();
            ctrlAddUpdateDiagnosis1.PatId = ID;
            ctrlAddUpdateDiagnosis1.PatName = PatientName;
            ctrlAddUpdateDiagnosis1.FillPatIDandPatName();
            

        }

        private void lblAddNew_Click(object sender, EventArgs e)
        {
        }

        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            if(!ctrlAddUpdateDiagnosis1.IsValidated())
            {
                return;
            }

         
            ctrlAddUpdateDiagnosis1.SaveAddnewDiagnosis();
          

        }
    }
}
