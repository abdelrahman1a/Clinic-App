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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            frm.ShowDialog();    
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPatient frm = new frmPatient();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmPatient frm = new frmPatient();
            frm.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmDiagnosis frm = new frmDiagnosis();
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmDiagnosis frm = new frmDiagnosis();
            frm.ShowDialog();
        }
    }
}
