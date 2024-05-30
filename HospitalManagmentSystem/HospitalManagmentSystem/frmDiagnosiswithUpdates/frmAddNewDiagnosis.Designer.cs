namespace HospitalManagmentSystem
{
    partial class frmAddNewDiagnosis
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
            this.btnSaveDiagnosis = new System.Windows.Forms.Button();
            this.ctrlAddUpdateDiagnosis1 = new HospitalManagmentSystem.ctrlAddUpdateDiagnosis();
            this.SuspendLayout();
            // 
            // btnSaveDiagnosis
            // 
            this.btnSaveDiagnosis.BackColor = System.Drawing.Color.Purple;
            this.btnSaveDiagnosis.FlatAppearance.BorderSize = 0;
            this.btnSaveDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDiagnosis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveDiagnosis.Location = new System.Drawing.Point(225, 376);
            this.btnSaveDiagnosis.Name = "btnSaveDiagnosis";
            this.btnSaveDiagnosis.Size = new System.Drawing.Size(220, 72);
            this.btnSaveDiagnosis.TabIndex = 31;
            this.btnSaveDiagnosis.Text = "Save Diagnosis";
            this.btnSaveDiagnosis.UseVisualStyleBackColor = false;
            this.btnSaveDiagnosis.Click += new System.EventHandler(this.btnSaveDiagnosis_Click);
            // 
            // ctrlAddUpdateDiagnosis1
            // 
            this.ctrlAddUpdateDiagnosis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAddUpdateDiagnosis1.Location = new System.Drawing.Point(13, 5);
            this.ctrlAddUpdateDiagnosis1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAddUpdateDiagnosis1.Name = "ctrlAddUpdateDiagnosis1";
            this.ctrlAddUpdateDiagnosis1.PatId = 0;
            this.ctrlAddUpdateDiagnosis1.PatName = null;
            this.ctrlAddUpdateDiagnosis1.Size = new System.Drawing.Size(686, 316);
            this.ctrlAddUpdateDiagnosis1.TabIndex = 0;
            this.ctrlAddUpdateDiagnosis1.Title = null;
            // 
            // frmDiagnosisData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(712, 513);
            this.Controls.Add(this.btnSaveDiagnosis);
            this.Controls.Add(this.ctrlAddUpdateDiagnosis1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDiagnosisData";
            this.Text = "frmSplash";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAddUpdateDiagnosis ctrlAddUpdateDiagnosis1;
        private System.Windows.Forms.Button btnSaveDiagnosis;
    }
}