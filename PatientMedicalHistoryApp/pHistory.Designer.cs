
namespace PatientMedicalHistoryApp
{
    partial class pHistory
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
            this.btnDeleteHistory = new System.Windows.Forms.Button();
            this.btnEditHistory = new System.Windows.Forms.Button();
            this.btnAddHistory = new System.Windows.Forms.Button();
            this.gvPatientHistory = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPatientAllergies = new System.Windows.Forms.Button();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(604, 55);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(253, 22);
            this.tbSearch.TabIndex = 50;
            this.tbSearch.Text = "Enter Search Text";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(54, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(192, 44);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewMedicalHistory
            // 
            this.btnViewMedicalHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicalHistory.Location = new System.Drawing.Point(78, 376);
            this.btnViewMedicalHistory.Name = "btnViewMedicalHistory";
            this.btnViewMedicalHistory.Size = new System.Drawing.Size(339, 41);
            this.btnViewMedicalHistory.TabIndex = 48;
            this.btnViewMedicalHistory.Text = "View Patient Demographics";
            this.btnViewMedicalHistory.UseVisualStyleBackColor = true;
            this.btnViewMedicalHistory.Click += new System.EventHandler(this.btnViewMedicalHistory_Click);
            // 
            // btnDeleteHistory
            // 
            this.btnDeleteHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHistory.Location = new System.Drawing.Point(604, 424);
            this.btnDeleteHistory.Name = "btnDeleteHistory";
            this.btnDeleteHistory.Size = new System.Drawing.Size(183, 43);
            this.btnDeleteHistory.TabIndex = 47;
            this.btnDeleteHistory.Text = "Delete History";
            this.btnDeleteHistory.UseVisualStyleBackColor = true;
            this.btnDeleteHistory.Click += new System.EventHandler(this.btnDeleteHistory_Click);
            // 
            // btnEditHistory
            // 
            this.btnEditHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHistory.Location = new System.Drawing.Point(337, 423);
            this.btnEditHistory.Name = "btnEditHistory";
            this.btnEditHistory.Size = new System.Drawing.Size(192, 44);
            this.btnEditHistory.TabIndex = 46;
            this.btnEditHistory.Text = "Edit History";
            this.btnEditHistory.UseVisualStyleBackColor = true;
            this.btnEditHistory.Click += new System.EventHandler(this.btnEditHistory_Click);
            // 
            // btnAddHistory
            // 
            this.btnAddHistory.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHistory.Location = new System.Drawing.Point(78, 423);
            this.btnAddHistory.Name = "btnAddHistory";
            this.btnAddHistory.Size = new System.Drawing.Size(192, 44);
            this.btnAddHistory.TabIndex = 45;
            this.btnAddHistory.Text = "Add History";
            this.btnAddHistory.UseVisualStyleBackColor = true;
            this.btnAddHistory.Click += new System.EventHandler(this.btnAddHistory_Click);
            // 
            // gvPatientHistory
            // 
            this.gvPatientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPatientHistory.Location = new System.Drawing.Point(54, 93);
            this.gvPatientHistory.Name = "gvPatientHistory";
            this.gvPatientHistory.RowHeadersWidth = 60;
            this.gvPatientHistory.RowTemplate.Height = 24;
            this.gvPatientHistory.Size = new System.Drawing.Size(759, 274);
            this.gvPatientHistory.TabIndex = 44;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(290, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 69);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "Patient History";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnPatientAllergies
            // 
            this.btnPatientAllergies.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientAllergies.Location = new System.Drawing.Point(484, 491);
            this.btnPatientAllergies.Name = "btnPatientAllergies";
            this.btnPatientAllergies.Size = new System.Drawing.Size(339, 41);
            this.btnPatientAllergies.TabIndex = 54;
            this.btnPatientAllergies.Text = "View Patient Allergies";
            this.btnPatientAllergies.UseVisualStyleBackColor = true;
            this.btnPatientAllergies.Click += new System.EventHandler(this.btnPatientAllergies_Click);
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.Location = new System.Drawing.Point(712, 382);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(126, 27);
            this.lblPatientAge.TabIndex = 52;
            this.lblPatientAge.Text = "Patient Age";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(439, 376);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(143, 27);
            this.lblPatientName.TabIndex = 51;
            this.lblPatientName.Text = "Patient Name";
            // 
            // pHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 540);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewMedicalHistory);
            this.Controls.Add(this.btnDeleteHistory);
            this.Controls.Add(this.btnEditHistory);
            this.Controls.Add(this.btnAddHistory);
            this.Controls.Add(this.gvPatientHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPatientAllergies);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatientName);
            this.Name = "pHistory";
            this.Text = "pHistory";
            this.Load += new System.EventHandler(this.pHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewMedicalHistory;
        private System.Windows.Forms.Button btnDeleteHistory;
        private System.Windows.Forms.Button btnEditHistory;
        private System.Windows.Forms.Button btnAddHistory;
        private System.Windows.Forms.DataGridView gvPatientHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnPatientAllergies;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblPatientName;
    }
}