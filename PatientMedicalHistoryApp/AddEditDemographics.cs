using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientMedicalHistoryApp
{
    public partial class AddEditDemographics : Form
    {
        private bool isEditMode;
        private readonly PatientMedicalHistoryEntities1 _db;

        public AddEditDemographics()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Demographics Record";
            this.Text = "Add New Demographics Record";
            isEditMode = false;
            _db = new PatientMedicalHistoryEntities1();
        }
        public AddEditDemographics(GeneralMedicalHistory recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Demographics Record";
            this.Text = "Edit Demographics Record";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new PatientMedicalHistoryEntities1();
                PopulateFields(recordToEdit);
            }

        }
        private void PopulateFields(GeneralMedicalHistory recordToEdit)
        {
            tbPatientNumberDemo.Text = recordToEdit.C_PatientID.ToString();
            tbMaritalStatus.Text = recordToEdit.MartialStatus.ToString();
            tbEducation.Text = recordToEdit.Education.ToString();
            tbBloodType.Text = recordToEdit.BloodType;
            tbPregnancies.Text = recordToEdit.Pregnancies;
            tbTobacco.Text = recordToEdit.Tobacco.ToString();
            tbAlcohol.Text = recordToEdit.Alcohol.ToString();
            tbDrugs.Text = recordToEdit.Drug.ToString();
            tbMedicalHistoryNotes.Text = recordToEdit.MedicalHistoryNotes.ToString();
            lblRecordId.Text = recordToEdit.Patient.PatientID.ToString();
            lblPatientName.Text = (string)recordToEdit.Patient.PatientFirstName + " " + recordToEdit.Patient.PatientLastName;


            //Selected DateOfBirth value
            var dob = (DateTime)recordToEdit.Patient.DateOfBirth;

            //Save today's date.
            var today = DateTime.Today;

            //Calculate the age.
            var age = today.Year - dob.Year;

            //Go back to the year in which the person was born in case of a leap year
            if (dob.Date > today.AddYears(-age)) age--;

            //Convert age to string and display it in label lblPatientAge
            lblPatientAge.Text = age.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var PatientNum = tbPatientNumberDemo.Text;
                string MaritalStatus = tbMaritalStatus.Text;
                string Education = tbEducation.Text;
                string BloodType = tbBloodType.Text;
                string Pregnancies = tbPregnancies.Text;
                string Tobacco = tbTobacco.Text;
                var Alcohol = tbAlcohol.Text;
                var Drug = tbDrugs.Text;
                var MedicalHistoryNotes = tbMedicalHistoryNotes.Text;

                var isValid = true;
                var errorMessage = "";

                if (   string.IsNullOrWhiteSpace(PatientNum)  || string.IsNullOrWhiteSpace(MaritalStatus) 
                    || string.IsNullOrWhiteSpace(Education)   || string.IsNullOrWhiteSpace(BloodType)
                    || string.IsNullOrWhiteSpace(Pregnancies) || string.IsNullOrWhiteSpace(Tobacco) 
                    || string.IsNullOrWhiteSpace(Alcohol)     || string.IsNullOrWhiteSpace(Drug) 
                    || string.IsNullOrWhiteSpace(MedicalHistoryNotes))
                {
                    errorMessage += "Error: Please Enter Missing Data.\n\r";
                    isValid = false;
                }

                if (isValid)
                {
                    var PatientRecord = new GeneralMedicalHistory();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblRecordId.Text);
                        PatientRecord = _db.GeneralMedicalHistories.FirstOrDefault(q => q.C_PatientID == id);
                    }
                    //Populate record object with values from the form
                    PatientRecord.C_PatientID = Convert.ToInt32(PatientNum);
                    PatientRecord.MartialStatus = MaritalStatus;
                    PatientRecord.Education = Education;
                    PatientRecord.BloodType = BloodType;
                    PatientRecord.Pregnancies = Pregnancies;
                    PatientRecord.Tobacco = Tobacco;
                    PatientRecord.Alcohol = Alcohol;
                    PatientRecord.Drug = Drug;
                    PatientRecord.MedicalHistoryNotes = MedicalHistoryNotes;

                    //If not in edit mode, then add the record object to the database
                    if (!isEditMode)
                        _db.GeneralMedicalHistories.Add(PatientRecord);

                    //Save changes made to the entity
                    _db.SaveChanges();


                    MessageBox.Show($"Demographic Added Successfully!");
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }


    }
}
