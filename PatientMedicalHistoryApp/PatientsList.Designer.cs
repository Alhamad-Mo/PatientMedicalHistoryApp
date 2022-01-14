
namespace PatientMedicalHistoryApp
{
    partial class PatientsList
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewMedicalHistory = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.gvPatients = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.btnPatientHistory = new System.Windows.Forms.Button();
            this.btnPatientAllergies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(579, 67);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(253, 22);
            this.tbSearch.TabIndex = 38;
            this.tbSearch.Text = "Enter Search Text";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged_1);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(29, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(192, 44);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewMedicalHistory
            // 
            this.btnViewMedicalHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicalHistory.Location = new System.Drawing.Point(53, 388);
            this.btnViewMedicalHistory.Name = "btnViewMedicalHistory";
            this.btnViewMedicalHistory.Size = new System.Drawing.Size(339, 41);
            this.btnViewMedicalHistory.TabIndex = 36;
            this.btnViewMedicalHistory.Text = "View Patient Demographics";
            this.btnViewMedicalHistory.UseVisualStyleBackColor = true;
            this.btnViewMedicalHistory.Click += new System.EventHandler(this.btnViewMedicalHistory_Click_1);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.Location = new System.Drawing.Point(579, 436);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(183, 43);
            this.btnDeletePatient.TabIndex = 35;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click_1);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPatient.Location = new System.Drawing.Point(312, 435);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(192, 44);
            this.btnEditPatient.TabIndex = 34;
            this.btnEditPatient.Text = "Edit Patient";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click_1);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(53, 435);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(192, 44);
            this.btnAddPatient.TabIndex = 33;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click_1);
            // 
            // gvPatients
            // 
            this.gvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPatients.Location = new System.Drawing.Point(29, 105);
            this.gvPatients.Name = "gvPatients";
            this.gvPatients.RowHeadersWidth = 60;
            this.gvPatients.RowTemplate.Height = 24;
            this.gvPatients.Size = new System.Drawing.Size(759, 274);
            this.gvPatients.TabIndex = 32;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(265, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 69);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Patients List";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.Location = new System.Drawing.Point(687, 394);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(126, 27);
            this.lblPatientAge.TabIndex = 40;
            this.lblPatientAge.Text = "Patient Age";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(414, 388);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(143, 27);
            this.lblPatientName.TabIndex = 39;
            this.lblPatientName.Text = "Patient Name";
            // 
            // btnPatientHistory
            // 
            this.btnPatientHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientHistory.Location = new System.Drawing.Point(63, 503);
            this.btnPatientHistory.Name = "btnPatientHistory";
            this.btnPatientHistory.Size = new System.Drawing.Size(339, 41);
            this.btnPatientHistory.TabIndex = 41;
            this.btnPatientHistory.Text = "View Patient History";
            this.btnPatientHistory.UseVisualStyleBackColor = true;
            this.btnPatientHistory.Click += new System.EventHandler(this.btnPatientHistory_Click);
            // 
            // btnPatientAllergies
            // 
            this.btnPatientAllergies.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientAllergies.Location = new System.Drawing.Point(459, 503);
            this.btnPatientAllergies.Name = "btnPatientAllergies";
            this.btnPatientAllergies.Size = new System.Drawing.Size(339, 41);
            this.btnPatientAllergies.TabIndex = 42;
            this.btnPatientAllergies.Text = "View Patient Allergies";
            this.btnPatientAllergies.UseVisualStyleBackColor = true;
            this.btnPatientAllergies.Click += new System.EventHandler(this.btnPatientAllergies_Click);
            // 
            // PatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 609);
            this.Controls.Add(this.btnPatientAllergies);
            this.Controls.Add(this.btnPatientHistory);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewMedicalHistory);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.gvPatients);
            this.Controls.Add(this.lblTitle);
            this.Name = "PatientsList";
            this.Text = "Patients List";
            this.Load += new System.EventHandler(this.PatientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewMedicalHistory;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.DataGridView gvPatients;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Button btnPatientHistory;
        private System.Windows.Forms.Button btnPatientAllergies;
    }
}