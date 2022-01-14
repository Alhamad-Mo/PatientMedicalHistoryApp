
namespace PatientMedicalHistoryApp
{
    partial class Allergy
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteAllergy = new System.Windows.Forms.Button();
            this.btnEditAllergy = new System.Windows.Forms.Button();
            this.btnAddAllergy = new System.Windows.Forms.Button();
            this.gvAllergies = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnPatientHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllergies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(81, 84);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(192, 44);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteAllergy
            // 
            this.btnDeleteAllergy.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllergy.Location = new System.Drawing.Point(622, 484);
            this.btnDeleteAllergy.Name = "btnDeleteAllergy";
            this.btnDeleteAllergy.Size = new System.Drawing.Size(183, 43);
            this.btnDeleteAllergy.TabIndex = 39;
            this.btnDeleteAllergy.Text = "Delete Allergy";
            this.btnDeleteAllergy.UseVisualStyleBackColor = true;
            this.btnDeleteAllergy.Click += new System.EventHandler(this.btnDeleteAllergy_Click);
            // 
            // btnEditAllergy
            // 
            this.btnEditAllergy.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAllergy.Location = new System.Drawing.Point(355, 483);
            this.btnEditAllergy.Name = "btnEditAllergy";
            this.btnEditAllergy.Size = new System.Drawing.Size(192, 44);
            this.btnEditAllergy.TabIndex = 38;
            this.btnEditAllergy.Text = "Edit Allergy";
            this.btnEditAllergy.UseVisualStyleBackColor = true;
            this.btnEditAllergy.Click += new System.EventHandler(this.btnEditAllergy_Click);
            // 
            // btnAddAllergy
            // 
            this.btnAddAllergy.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllergy.Location = new System.Drawing.Point(96, 483);
            this.btnAddAllergy.Name = "btnAddAllergy";
            this.btnAddAllergy.Size = new System.Drawing.Size(192, 44);
            this.btnAddAllergy.TabIndex = 37;
            this.btnAddAllergy.Text = "Add Allergy";
            this.btnAddAllergy.UseVisualStyleBackColor = true;
            this.btnAddAllergy.Click += new System.EventHandler(this.btnAddAllergy_Click);
            // 
            // gvAllergies
            // 
            this.gvAllergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAllergies.Location = new System.Drawing.Point(76, 134);
            this.gvAllergies.Name = "gvAllergies";
            this.gvAllergies.RowHeadersWidth = 60;
            this.gvAllergies.RowTemplate.Height = 24;
            this.gvAllergies.Size = new System.Drawing.Size(759, 274);
            this.gvAllergies.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(279, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 69);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Allergy";
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.Location = new System.Drawing.Point(753, 72);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(126, 27);
            this.lblPatientAge.TabIndex = 43;
            this.lblPatientAge.Text = "Patient Age";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(517, 72);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(143, 27);
            this.lblPatientName.TabIndex = 42;
            this.lblPatientName.Text = "Patient Name";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(427, 427);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(253, 22);
            this.tbSearch.TabIndex = 44;
            this.tbSearch.Text = "Enter Search Text";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // btnPatientHistory
            // 
            this.btnPatientHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientHistory.Location = new System.Drawing.Point(76, 427);
            this.btnPatientHistory.Name = "btnPatientHistory";
            this.btnPatientHistory.Size = new System.Drawing.Size(339, 41);
            this.btnPatientHistory.TabIndex = 45;
            this.btnPatientHistory.Text = "View Patient History";
            this.btnPatientHistory.UseVisualStyleBackColor = true;
            this.btnPatientHistory.Click += new System.EventHandler(this.btnPatientHistory_Click);
            // 
            // Allergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 614);
            this.Controls.Add(this.btnPatientHistory);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteAllergy);
            this.Controls.Add(this.btnEditAllergy);
            this.Controls.Add(this.btnAddAllergy);
            this.Controls.Add(this.gvAllergies);
            this.Controls.Add(this.lblTitle);
            this.Name = "Allergy";
            this.Text = "Allergy";
            this.Load += new System.EventHandler(this.Allergy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAllergies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteAllergy;
        private System.Windows.Forms.Button btnEditAllergy;
        private System.Windows.Forms.Button btnAddAllergy;
        private System.Windows.Forms.DataGridView gvAllergies;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnPatientHistory;
    }
}