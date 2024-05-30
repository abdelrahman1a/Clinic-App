namespace HospitalManagmentSystem
{
    partial class frmPatient
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbBloodGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbUpdatePatient = new System.Windows.Forms.RadioButton();
            this.rbDeletepatient = new System.Windows.Forms.RadioButton();
            this.rbAddNewPatient = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPatientAge = new HospitalManagmentSystem.CustomControlTextBox();
            this.lblPatientName = new HospitalManagmentSystem.CustomControlTextBox();
            this.lblPatientAddress = new HospitalManagmentSystem.CustomControlTextBox();
            this.lblPatientID = new HospitalManagmentSystem.CustomControlTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 116);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(811, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(576, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Managment System";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Purple;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Location = new System.Drawing.Point(167, 663);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(154, 72);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(336, 573);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 72);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(178, 573);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 72);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Purple;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(8, 573);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 72);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(488, 181);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(1404, 693);
            this.dgvPatients.TabIndex = 17;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.SystemColors.Window;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.Color.Purple;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(50, 416);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(240, 28);
            this.cbGender.TabIndex = 23;
            this.cbGender.Text = "Gender";
            // 
            // cbBloodGroup
            // 
            this.cbBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBloodGroup.ForeColor = System.Drawing.Color.Purple;
            this.cbBloodGroup.FormattingEnabled = true;
            this.cbBloodGroup.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.cbBloodGroup.Location = new System.Drawing.Point(50, 469);
            this.cbBloodGroup.Name = "cbBloodGroup";
            this.cbBloodGroup.Size = new System.Drawing.Size(240, 28);
            this.cbBloodGroup.TabIndex = 24;
            this.cbBloodGroup.Text = "BloodGroup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(1113, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient List";
            // 
            // rbUpdatePatient
            // 
            this.rbUpdatePatient.AutoSize = true;
            this.rbUpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdatePatient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbUpdatePatient.Location = new System.Drawing.Point(201, 122);
            this.rbUpdatePatient.Name = "rbUpdatePatient";
            this.rbUpdatePatient.Size = new System.Drawing.Size(175, 29);
            this.rbUpdatePatient.TabIndex = 28;
            this.rbUpdatePatient.TabStop = true;
            this.rbUpdatePatient.Text = "Update Patient";
            this.rbUpdatePatient.UseVisualStyleBackColor = true;
            this.rbUpdatePatient.CheckedChanged += new System.EventHandler(this.rbUpdatePatient_CheckedChanged);
            // 
            // rbDeletepatient
            // 
            this.rbDeletepatient.AutoSize = true;
            this.rbDeletepatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeletepatient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbDeletepatient.Location = new System.Drawing.Point(417, 122);
            this.rbDeletepatient.Name = "rbDeletepatient";
            this.rbDeletepatient.Size = new System.Drawing.Size(168, 29);
            this.rbDeletepatient.TabIndex = 27;
            this.rbDeletepatient.TabStop = true;
            this.rbDeletepatient.Text = "Delete Patient";
            this.rbDeletepatient.UseVisualStyleBackColor = true;
            this.rbDeletepatient.CheckedChanged += new System.EventHandler(this.rbDeletepatient_CheckedChanged);
            // 
            // rbAddNewPatient
            // 
            this.rbAddNewPatient.AutoSize = true;
            this.rbAddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAddNewPatient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbAddNewPatient.Location = new System.Drawing.Point(37, 122);
            this.rbAddNewPatient.Name = "rbAddNewPatient";
            this.rbAddNewPatient.Size = new System.Drawing.Size(139, 29);
            this.rbAddNewPatient.TabIndex = 26;
            this.rbAddNewPatient.TabStop = true;
            this.rbAddNewPatient.Text = "AddPatient";
            this.rbAddNewPatient.UseVisualStyleBackColor = true;
            this.rbAddNewPatient.CheckedChanged += new System.EventHandler(this.rbAddNewPatient_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.BackColor = System.Drawing.Color.Silver;
            this.lblPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPatientAge.BottomBorderColor = System.Drawing.Color.Black;
            this.lblPatientAge.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPatientAge.Location = new System.Drawing.Point(50, 349);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(240, 22);
            this.lblPatientAge.TabIndex = 22;
            this.lblPatientAge.Text = "PatientAge";
            // 
            // lblPatientName
            // 
            this.lblPatientName.BackColor = System.Drawing.Color.Silver;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPatientName.BottomBorderColor = System.Drawing.Color.Black;
            this.lblPatientName.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPatientName.Location = new System.Drawing.Point(50, 235);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(240, 22);
            this.lblPatientName.TabIndex = 16;
            this.lblPatientName.Text = "PatientName";
           
            // 
            // lblPatientAddress
            // 
            this.lblPatientAddress.BackColor = System.Drawing.Color.Silver;
            this.lblPatientAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPatientAddress.BottomBorderColor = System.Drawing.Color.Black;
            this.lblPatientAddress.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.lblPatientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPatientAddress.Location = new System.Drawing.Point(50, 290);
            this.lblPatientAddress.Name = "lblPatientAddress";
            this.lblPatientAddress.Size = new System.Drawing.Size(240, 22);
            this.lblPatientAddress.TabIndex = 15;
            this.lblPatientAddress.Text = "PatientAddress";
            // 
            // lblPatientID
            // 
            this.lblPatientID.BackColor = System.Drawing.Color.Silver;
            this.lblPatientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPatientID.BottomBorderColor = System.Drawing.Color.Black;
            this.lblPatientID.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPatientID.Location = new System.Drawing.Point(50, 186);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(240, 22);
            this.lblPatientID.TabIndex = 13;
            this.lblPatientID.Text = "Patient ID";
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1904, 868);
            this.Controls.Add(this.rbUpdatePatient);
            this.Controls.Add(this.rbDeletepatient);
            this.Controls.Add(this.rbAddNewPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBloodGroup);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblPatientAddress);
            this.Controls.Add(this.lblPatientID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPatient";
            this.Text = "frmPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPatients;
        private CustomControlTextBox lblPatientName;
        private CustomControlTextBox lblPatientAddress;
        private CustomControlTextBox lblPatientID;
        private CustomControlTextBox lblPatientAge;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbBloodGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbUpdatePatient;
        private System.Windows.Forms.RadioButton rbDeletepatient;
        private System.Windows.Forms.RadioButton rbAddNewPatient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}