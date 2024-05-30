using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_Buisness;

namespace HospitalManagmentSystem
{
    public partial class frmDoctor : Form
    {
    
        private static DataTable _dtAllDoctors;

        public frmDoctor()
        {
            InitializeComponent();
        

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.ShowDialog();
        }
        
        private void frmDoctor_Load(object sender, EventArgs e)
        {
           
            rbAddNew.Checked = true;

            //txtDocName.Focus();
            _dtAllDoctors = clsDoctors.GetAllDoctors();
            dgvDoctors.DataSource = _dtAllDoctors;

            var recordscount = dgvDoctors.Rows.Count - 1;
            lblRecords.Text = recordscount.ToString();
         

            if (dgvDoctors.Rows.Count > 0)
            {
                dgvDoctors.Columns[0].HeaderText = "Doctor ID";
                dgvDoctors.Columns[0].Width = 100;

                dgvDoctors.Columns[1].HeaderText = "Doctor Name";
                dgvDoctors.Columns[1].Width = 220;

                dgvDoctors.Columns[2].HeaderText = "Doctor Experience";
                dgvDoctors.Columns[2].Width = 250;

                dgvDoctors.Columns[3].HeaderText = "Doctor Specialization";
                dgvDoctors.Columns[3].Width = 320;


            }


        }

        private void _ResetAddNew()
        {
            txtDocID.Enabled = false;
            txtPass.Enabled = true;
            txtDocName.Enabled = true;
            txtYearsofExp.Enabled = true;
            txtSpecialization.Enabled = true;
        
        }

        private void _ReseteDelete()
        {
            txtDocID.Enabled = true;    
            txtDocName.Enabled = false;    
            txtYearsofExp.Enabled = false;
            txtSpecialization.Enabled = false;  
            txtPass.Enabled = false;
        }
        private void _ReseteUpdate()
        {
            txtDocID.Enabled = true;
            txtDocName.Enabled = true;
            txtYearsofExp.Enabled = true;
            txtSpecialization.Enabled = true;
            txtPass.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           if(!ValidateAddDoctor())
            {
                return;
            }
            clsDoctors doctor = new clsDoctors();
            doctor.DoctorName = txtDocName.Text.Trim();
            doctor.DoctorPassword = txtPass.Text.Trim();

            if (int.TryParse(txtYearsofExp.Text.Trim(), out int res))
            {
                doctor.DocExp = res;
            }
            else
            {
                MessageBox.Show("Enter a Valid Years of Experience");
            }
            doctor.DoctorSpecialization = txtDocName.Text.Trim();

            if (doctor.Save())
            {
                MessageBox.Show("Doctor Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error In Adding Doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _ResetValues();
            frmDoctor_Load(null, null);

        }


        private bool ValidateAddDoctor()
        {
            bool isvalidated = true;
            if(txtDocName.Text == string.Empty || txtDocName.Text == "DoctorName")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Doctor Name");
            }
            else if (txtYearsofExp.Text == "YearsOfExperience" || txtYearsofExp.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Years of Experience Name");
            }
            else if (txtSpecialization.Text == "Specialization" || txtSpecialization.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Specialization");
            }
            else if (txtPass.Text == "*******" || txtPass.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Your Own Password");
            }

            return isvalidated;
        }

        private bool ValidateUpdateDoctor()
        {
            bool isvalidated = true;
            if (txtDocID.Text == string.Empty || txtDocID.Text == "Doctor ID")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid DoctorID");
            }
           else if (txtDocName.Text == string.Empty || txtDocName.Text == "DoctorName")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Doctor Name");
            }
            else if (txtYearsofExp.Text == "YearsOfExperience" || txtYearsofExp.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Years of Experience Name");
            }
            else if (txtSpecialization.Text == "Specialization" || txtSpecialization.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid Specialization");
            }
            else if (txtPass.Text == "*******" || txtPass.Text == string.Empty)
            {
                isvalidated = false;
                MessageBox.Show("Enter Your Own Password");
            }

            return isvalidated;
        }

        private bool ValidateDeleteDoctor()
        {
            bool isvalidated = true;
            if (txtDocID.Text == string.Empty || txtDocID.Text == "Doctor ID")
            {
                isvalidated = false;
                MessageBox.Show("Enter Valid DoctorID");
            }

            return isvalidated;
        }
        private void _ResetValues()
        {
            txtDocID.Text = "Doctor ID";
            txtDocName.Text = "Doctor Name";
            txtPass.Text = "*******";
            txtSpecialization.Text = "Specialization";
            txtYearsofExp.Text = "YearsOfExperience";

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!ValidateUpdateDoctor())
            {
                return;
            }
            int DoID , yearsofExp;
            if (int.TryParse(txtDocID.Text , out int res))
            {
                DoID = res; 
            }
            else
            {
                MessageBox.Show("Errored DoctorID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(txtYearsofExp.Text, out int result))
            {
                yearsofExp = result;
            }
            else
            {
                MessageBox.Show("Errored Years of Experience", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsDoctors doct = new clsDoctors(DoID, txtDocName.Text.Trim() , yearsofExp, txtPass.Text.Trim() , txtSpecialization.Text.Trim());       
            if (doct.Save())
            {
                MessageBox.Show("Doctor With ID = " + txtDocID.Text + " Updated Successfully ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Doctor With ID = " + txtDocID.Text + " Error In Updating ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            _ResetValues();
            frmDoctor_Load(null, null);
        }



        private void txtDocID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void txtYearsofExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if (!ValidateDeleteDoctor())
            {
                return;
            }
            int docID = 0;
            if(int.TryParse(txtDocID.Text.Trim() , out int res) )
            {
                docID = res;
            }
            bool IsDeleted = clsDoctors.Delete(docID);
            if (IsDeleted)
            {
                MessageBox.Show("Doctor With ID = " + docID + "Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error In Deleting Doctor with ID = " + docID , "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            _ResetValues();
            frmDoctor_Load(null, null);
        }

        private void rbAddNew_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            _ResetAddNew();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;  
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
              _ReseteUpdate ();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            _ReseteDelete();
            btnAdd.Enabled = false;
            btnUpdate.Enabled =false;   
        }

   
    }
}
