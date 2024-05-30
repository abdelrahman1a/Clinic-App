namespace HospitalManagmentSystem
{
    partial class frmDiagnosis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiagnosisPatientList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPatientIDs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.llbPatientForm = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteDiagnosis = new System.Windows.Forms.Button();
            this.btnUpdateDiagnosis = new System.Windows.Forms.Button();
            this.btnAddDiagnosis = new System.Windows.Forms.Button();
            this.ctrlDiagnosisPatient1 = new HospitalManagmentSystem.ctrlDiagnosisPatient();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosisPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 116);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(600, -259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Patient List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(849, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diagnosis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(614, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Managment System";
            // 
            // dgvDiagnosisPatientList
            // 
            this.dgvDiagnosisPatientList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagnosisPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosisPatientList.Location = new System.Drawing.Point(686, 191);
            this.dgvDiagnosisPatientList.Name = "dgvDiagnosisPatientList";
            this.dgvDiagnosisPatientList.RowHeadersWidth = 51;
            this.dgvDiagnosisPatientList.RowTemplate.Height = 24;
            this.dgvDiagnosisPatientList.Size = new System.Drawing.Size(1226, 624);
            this.dgvDiagnosisPatientList.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(1129, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 38);
            this.label4.TabIndex = 20;
            this.label4.Text = "Diagnosis Patient List";
            // 
            // cbPatientIDs
            // 
            this.cbPatientIDs.BackColor = System.Drawing.SystemColors.Window;
            this.cbPatientIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPatientIDs.ForeColor = System.Drawing.Color.Purple;
            this.cbPatientIDs.FormattingEnabled = true;
            this.cbPatientIDs.Location = new System.Drawing.Point(175, 129);
            this.cbPatientIDs.Name = "cbPatientIDs";
            this.cbPatientIDs.Size = new System.Drawing.Size(240, 28);
            this.cbPatientIDs.TabIndex = 24;
            this.cbPatientIDs.Text = "Patient IDs";
            this.cbPatientIDs.SelectedIndexChanged += new System.EventHandler(this.cbPatientIDs_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Choose Patient ID:";
            // 
            // llbPatientForm
            // 
            this.llbPatientForm.AutoSize = true;
            this.llbPatientForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPatientForm.Location = new System.Drawing.Point(229, 186);
            this.llbPatientForm.Name = "llbPatientForm";
            this.llbPatientForm.Size = new System.Drawing.Size(242, 29);
            this.llbPatientForm.TabIndex = 27;
            this.llbPatientForm.TabStop = true;
            this.llbPatientForm.Text = "Go To Patient Form";
            this.llbPatientForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbPatientForm_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Go To Patient Form:";
            // 
            // btnDeleteDiagnosis
            // 
            this.btnDeleteDiagnosis.BackColor = System.Drawing.Color.Purple;
            this.btnDeleteDiagnosis.FlatAppearance.BorderSize = 0;
            this.btnDeleteDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDiagnosis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteDiagnosis.Location = new System.Drawing.Point(172, 662);
            this.btnDeleteDiagnosis.Name = "btnDeleteDiagnosis";
            this.btnDeleteDiagnosis.Size = new System.Drawing.Size(187, 72);
            this.btnDeleteDiagnosis.TabIndex = 30;
            this.btnDeleteDiagnosis.Text = "Delete Diagnosis";
            this.btnDeleteDiagnosis.UseVisualStyleBackColor = false;
            this.btnDeleteDiagnosis.Click += new System.EventHandler(this.btnDeleteDiagnosis_Click);
            // 
            // btnUpdateDiagnosis
            // 
            this.btnUpdateDiagnosis.BackColor = System.Drawing.Color.Purple;
            this.btnUpdateDiagnosis.FlatAppearance.BorderSize = 0;
            this.btnUpdateDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDiagnosis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateDiagnosis.Location = new System.Drawing.Point(314, 562);
            this.btnUpdateDiagnosis.Name = "btnUpdateDiagnosis";
            this.btnUpdateDiagnosis.Size = new System.Drawing.Size(187, 72);
            this.btnUpdateDiagnosis.TabIndex = 31;
            this.btnUpdateDiagnosis.Text = "Update Diagnosis";
            this.btnUpdateDiagnosis.UseVisualStyleBackColor = false;
            this.btnUpdateDiagnosis.Click += new System.EventHandler(this.btnUpdateDiagnosis_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.BackColor = System.Drawing.Color.Purple;
            this.btnAddDiagnosis.FlatAppearance.BorderSize = 0;
            this.btnAddDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiagnosis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDiagnosis.Location = new System.Drawing.Point(27, 562);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(187, 72);
            this.btnAddDiagnosis.TabIndex = 32;
            this.btnAddDiagnosis.Text = "Add Diagnosis";
            this.btnAddDiagnosis.UseVisualStyleBackColor = false;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // ctrlDiagnosisPatient1
            // 
            this.ctrlDiagnosisPatient1.Diagnosis = "";
            this.ctrlDiagnosisPatient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDiagnosisPatient1.Location = new System.Drawing.Point(0, 236);
            this.ctrlDiagnosisPatient1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlDiagnosisPatient1.Medicine = "";
            this.ctrlDiagnosisPatient1.Name = "ctrlDiagnosisPatient1";
            this.ctrlDiagnosisPatient1.PatientID = -1;
            this.ctrlDiagnosisPatient1.PatientName = "";
            this.ctrlDiagnosisPatient1.Size = new System.Drawing.Size(662, 283);
            this.ctrlDiagnosisPatient1.Symptoms = "";
            this.ctrlDiagnosisPatient1.TabIndex = 29;
            // 
            // frmDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 817);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnUpdateDiagnosis);
            this.Controls.Add(this.btnDeleteDiagnosis);
            this.Controls.Add(this.ctrlDiagnosisPatient1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llbPatientForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPatientIDs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDiagnosisPatientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDiagnosis";
            this.Text = "frmDiagnosis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDiagnosis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosisPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDiagnosisPatientList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPatientIDs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llbPatientForm;
        private System.Windows.Forms.Label label6;
        private ctrlDiagnosisPatient ctrlDiagnosisPatient1;
        private System.Windows.Forms.Button btnDeleteDiagnosis;
        private System.Windows.Forms.Button btnUpdateDiagnosis;
        private System.Windows.Forms.Button btnAddDiagnosis;
    }
}