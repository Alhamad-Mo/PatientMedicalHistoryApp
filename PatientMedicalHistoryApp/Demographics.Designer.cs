
namespace PatientMedicalHistoryApp
{
    partial class Demographics
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
            this.gvDemographics = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewAllergyHistory = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDemographics)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDemographics
            // 
            this.gvDemographics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDemographics.Location = new System.Drawing.Point(21, 131);
            this.gvDemographics.Name = "gvDemographics";
            this.gvDemographics.RowHeadersWidth = 60;
            this.gvDemographics.RowTemplate.Height = 24;
            this.gvDemographics.Size = new System.Drawing.Size(759, 274);
            this.gvDemographics.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(224, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 69);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Demographics";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(26, 81);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(192, 44);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewAllergyHistory
            // 
            this.btnViewAllergyHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllergyHistory.Location = new System.Drawing.Point(41, 433);
            this.btnViewAllergyHistory.Name = "btnViewAllergyHistory";
            this.btnViewAllergyHistory.Size = new System.Drawing.Size(282, 41);
            this.btnViewAllergyHistory.TabIndex = 33;
            this.btnViewAllergyHistory.Text = "View Allergy History";
            this.btnViewAllergyHistory.UseVisualStyleBackColor = true;
            this.btnViewAllergyHistory.Click += new System.EventHandler(this.btnViewAllergyHistory_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.Location = new System.Drawing.Point(567, 481);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(183, 43);
            this.btnDeletePatient.TabIndex = 32;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPatient.Location = new System.Drawing.Point(300, 480);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(192, 44);
            this.btnEditPatient.TabIndex = 31;
            this.btnEditPatient.Text = "Edit Patient";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(41, 480);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(192, 44);
            this.btnAddPatient.TabIndex = 30;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(444, 98);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(143, 27);
            this.lblPatientName.TabIndex = 35;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.Location = new System.Drawing.Point(704, 98);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(126, 27);
            this.lblPatientAge.TabIndex = 36;
            this.lblPatientAge.Text = "Patient Age";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(354, 453);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(253, 22);
            this.tbSearch.TabIndex = 37;
            this.tbSearch.Text = "Enter Search Text";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "View Patient History";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Demographics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewAllergyHistory);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.gvDemographics);
            this.Controls.Add(this.lblTitle);
            this.Name = "Demographics";
            this.Text = "Demographics";
            this.Load += new System.EventHandler(this.Demographics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDemographics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDemographics;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewAllergyHistory;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button1;
    }
}