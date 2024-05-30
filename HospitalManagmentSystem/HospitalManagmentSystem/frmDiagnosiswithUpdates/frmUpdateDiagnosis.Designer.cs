namespace HospitalManagmentSystem.frmDiagnosiswithUpdates
{
    partial class frmUpdateDiagnosis
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
            this.btnSaveUpdates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveUpdates
            // 
            this.btnSaveUpdates.BackColor = System.Drawing.Color.Purple;
            this.btnSaveUpdates.FlatAppearance.BorderSize = 0;
            this.btnSaveUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdates.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveUpdates.Location = new System.Drawing.Point(506, 359);
            this.btnSaveUpdates.Name = "btnSaveUpdates";
            this.btnSaveUpdates.Size = new System.Drawing.Size(220, 72);
            this.btnSaveUpdates.TabIndex = 32;
            this.btnSaveUpdates.Text = "Save Updates";
            this.btnSaveUpdates.UseVisualStyleBackColor = false;
            this.btnSaveUpdates.Click += new System.EventHandler(this.btnSaveUpdates_Click);
            // 
            // frmUpdateDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 453);
            this.Controls.Add(this.btnSaveUpdates);
            this.Name = "frmUpdateDiagnosis";
            this.Text = "frmUpdateDiagnosis";
            this.Load += new System.EventHandler(this.frmUpdateDiagnosis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveUpdates;
    }
}