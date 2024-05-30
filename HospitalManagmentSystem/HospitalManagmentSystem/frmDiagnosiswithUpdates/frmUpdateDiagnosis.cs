using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalManagmentSystem.frmDiagnosiswithUpdates
{
    public partial class frmUpdateDiagnosis : Form
    {
        private ctrlAddUpdateDiagnosis ctrl;

        public frmUpdateDiagnosis(int patID , string Name)
        {
            InitializeComponent();
            // Create an instance of ctrlAddUpdateDiagnosis
            if(ctrl == null)
            {
                ctrl = new ctrlAddUpdateDiagnosis();

                // Set properties of ctrlAddUpdateDiagnosis
                ctrl.Title = "Update Diagnosis";
                ctrl.PatId = patID;
                ctrl.PatName = Name;
                ctrl.FillPatIDandPatName();

                // Add ctrlAddUpdateDiagnosis to the form's controls
                this.Controls.Add(ctrl);
            }
          
        }

        private void frmUpdateDiagnosis_Load(object sender, EventArgs e)
        {
        
        }

        private void btnSaveUpdates_Click(object sender, EventArgs e)
        {
            if (!ctrl.IsValidated())
            {
                return;
            }


            ctrl.SaveUpdateDiagnosis();

        }
    }
}
