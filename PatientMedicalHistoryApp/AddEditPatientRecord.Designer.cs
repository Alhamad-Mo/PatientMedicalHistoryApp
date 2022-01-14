
namespace PatientMedicalHistoryApp
{
    partial class AddEditPatientRecord
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
            this.lblRecordId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPatientFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPatientLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(345, 361);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 17);
            this.lblRecordId.TabIndex = 28;
            this.lblRecordId.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(136, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(452, 69);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Add Patient Record";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(597, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 52);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer Not To Answer"});
            this.cbGender.Location = new System.Drawing.Point(70, 330);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(282, 24);
            this.cbGender.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date of Birth";
            // 
            // dtOfBirth
            // 
            this.dtOfBirth.Location = new System.Drawing.Point(69, 268);
            this.dtOfBirth.Name = "dtOfBirth";
            this.dtOfBirth.Size = new System.Drawing.Size(269, 22);
            this.dtOfBirth.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Patient First Name";
            // 
            // tbPatientFirstName
            // 
            this.tbPatientFirstName.Location = new System.Drawing.Point(68, 141);
            this.tbPatientFirstName.Name = "tbPatientFirstName";
            this.tbPatientFirstName.Size = new System.Drawing.Size(269, 22);
            this.tbPatientFirstName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Patient Last Name";
            // 
            // tbPatientLastName
            // 
            this.tbPatientLastName.Location = new System.Drawing.Point(68, 194);
            this.tbPatientLastName.Name = "tbPatientLastName";
            this.tbPatientLastName.Size = new System.Drawing.Size(269, 22);
            this.tbPatientLastName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(381, 122);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(358, 22);
            this.tbAddress.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "State";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(381, 171);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(358, 22);
            this.tbState.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "City";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(381, 220);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(358, 22);
            this.tbCity.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Zip Code";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(381, 280);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(358, 22);
            this.tbZipCode.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "Contact Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Location = new System.Drawing.Point(381, 330);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(358, 22);
            this.tbContactNumber.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 42;
            this.label10.Text = "Email";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(394, 373);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(358, 22);
            this.tbEmail.TabIndex = 41;
            // 
            // lblPatientAge
            // 
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAge.Location = new System.Drawing.Point(636, 74);
            this.lblPatientAge.Name = "lblPatientAge";
            this.lblPatientAge.Size = new System.Drawing.Size(126, 27);
            this.lblPatientAge.TabIndex = 44;
            this.lblPatientAge.Text = "Patient Age";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(619, 19);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(143, 27);
            this.lblPatientName.TabIndex = 43;
            this.lblPatientName.Text = "Patient Name";
            // 
            // AddEditPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPatientAge);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbContactNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPatientLastName);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtOfBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPatientFirstName);
            this.Name = "AddEditPatientRecord";
            this.Text = "AddEditPatientRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPatientFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatientLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblPatientName;
    }
}