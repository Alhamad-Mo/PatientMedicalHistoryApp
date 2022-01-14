
namespace PatientMedicalHistoryApp
{
    partial class AddEditAllergy
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbPatientNumberDemo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAllergyDescription = new System.Windows.Forms.TextBox();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAllergen = new System.Windows.Forms.TextBox();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 88;
            this.label3.Text = "Patient Number";
            // 
            // tbPatientNumberDemo
            // 
            this.tbPatientNumberDemo.Location = new System.Drawing.Point(70, 170);
            this.tbPatientNumberDemo.Name = "tbPatientNumberDemo";
            this.tbPatientNumberDemo.Size = new System.Drawing.Size(269, 22);
            this.tbPatientNumberDemo.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Allergy Description";
            // 
            // tbAllergyDescription
            // 
            this.tbAllergyDescription.Location = new System.Drawing.Point(71, 283);
            this.tbAllergyDescription.Multiline = true;
            this.tbAllergyDescription.Name = "tbAllergyDescription";
            this.tbAllergyDescription.Size = new System.Drawing.Size(351, 138);
            this.tbAllergyDescription.TabIndex = 73;
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(347, 395);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 17);
            this.lblRecordId.TabIndex = 72;
            this.lblRecordId.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(138, 66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(449, 69);
            this.lblTitle.TabIndex = 71;
            this.lblTitle.Text = "Add Allergy Record";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(609, 440);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 52);
            this.btnSubmit.TabIndex = 70;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Allergen";
            // 
            // tbAllergen
            // 
            this.tbAllergen.Location = new System.Drawing.Point(70, 218);
            this.tbAllergen.Name = "tbAllergen";
            this.tbAllergen.Size = new System.Drawing.Size(269, 22);
            this.tbAllergen.TabIndex = 68;
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.Location = new System.Drawing.Point(624, 147);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(126, 27);
            this.lblPatientAge.TabIndex = 90;
            this.lblPatientAge.Text = "Patient Age";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(624, 89);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(143, 27);
            this.lblPatientName.TabIndex = 89;
            this.lblPatientName.Text = "Patient Name";
            // 
            // AddEditAllergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 558);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPatientNumberDemo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAllergyDescription);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAllergen);
            this.Name = "AddEditAllergy";
            this.Text = "AddEditAllergy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPatientNumberDemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAllergyDescription;
        private System.Windows.Forms.Label lblRecordId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAllergen;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblPatientName;
    }
}