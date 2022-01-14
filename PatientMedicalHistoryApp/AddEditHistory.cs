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
    public partial class AddEditHistory : Form
    {
        private bool isEditMode;
        private readonly PatientMedicalHistoryEntities1 _db;
        public AddEditHistory()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Patient History";
            this.Text = "Add New Patient History";
            isEditMode = false;
            _db = new PatientMedicalHistoryEntities1();
        }
        public AddEditHistory(PatientHistory recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Patient History";
            this.Text = "Edit Patient History";
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
        private void PopulateFields(PatientHistory recordToEdit)
        {
            tbPatientNumberDemo.Text = recordToEdit.C_PatientID.ToString();
            tbDiseaseHistory.Text = recordToEdit.DiseaseHistory.ToString();
            tbSurgeryHistory.Text = recordToEdit.SurgeryHistory.ToString();
            tbMenstrualHistory.Text = recordToEdit.MenstrualHistory.ToString();
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
                string DiseaseHistory = tbDiseaseHistory.Text;
                string SurgeryHistory = tbSurgeryHistory.Text;
                string MenstrualHistory = tbMenstrualHistory.Text;

                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(PatientNum) || string.IsNullOrWhiteSpace(DiseaseHistory) ||
                    string.IsNullOrWhiteSpace(SurgeryHistory) || string.IsNullOrWhiteSpace(MenstrualHistory))
                {
                    errorMessage += "Error: Please Enter Missing Data.\n\r";
                    isValid = false;
                }

                if (isValid)
                {
                    var PatientRecord = new PatientHistory();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblRecordId.Text);
                        PatientRecord = _db.PatientHistories.FirstOrDefault(q => q.C_PatientID == id);
                    }
                    //Populate record object with values from the form
                    PatientRecord.C_PatientID = Convert.ToInt32(PatientNum);
                    PatientRecord.DiseaseHistory = DiseaseHistory;
                    PatientRecord.SurgeryHistory = SurgeryHistory;
                    PatientRecord.MenstrualHistory = MenstrualHistory;

                    //If not in edit mode, then add the record object to the database
                    if (!isEditMode)
                        _db.PatientHistories.Add(PatientRecord);

                    //Save changes made to the entity
                    _db.SaveChanges();


                    MessageBox.Show($"History Added Successfully!");
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
