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
    public partial class AddEditAllergy : Form
    {
        private bool isEditMode;
        private readonly PatientMedicalHistoryEntities1 _db;
        public AddEditAllergy()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Allergy Record";
            this.Text = "Add New Allergy Record";
            isEditMode = false;
            _db = new PatientMedicalHistoryEntities1();
        }

        public AddEditAllergy(AllergyHistory recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Allergy Record";
            this.Text = "Edit Allergy Record";
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

        private void PopulateFields(AllergyHistory recordToEdit)
        {
            tbPatientNumberDemo.Text = recordToEdit.C_PatientID.ToString();
            tbAllergen.Text = recordToEdit.Allergen.ToString();
            tbAllergyDescription.Text = recordToEdit.AllergyDescription.ToString();
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
                string Allergen = tbAllergen.Text;
                string Description = tbAllergyDescription.Text;

                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(Allergen) || string.IsNullOrWhiteSpace(Description))
                {
                    errorMessage += "Error: Please Enter Missing Data.\n\r";
                    isValid = false;
                }

                if (isValid)
                {
                    var PatientRecord = new AllergyHistory();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblRecordId.Text);
                        PatientRecord = _db.AllergyHistories.FirstOrDefault(q => q.C_PatientID == id);
                    }
                    //Populate record object with values from the form
                    PatientRecord.C_PatientID = Convert.ToInt32(PatientNum);
                    PatientRecord.Allergen = Allergen;
                    PatientRecord.AllergyDescription = Description;

                    //If not in edit mode, then add the record object to the database
                    if (!isEditMode)
                        _db.AllergyHistories.Add(PatientRecord);

                    //Save changes made to the entity
                    _db.SaveChanges();


                    MessageBox.Show($"Allergy Added Successfully!");
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
