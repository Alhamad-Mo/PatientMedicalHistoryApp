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
    public partial class AddEditPatientRecord : Form
    {
        private bool isEditMode;
        private readonly PatientMedicalHistoryEntities1 _db;

        public AddEditPatientRecord()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Patient Record";
            this.Text = "Add New Patient Record";
            isEditMode = false;
            _db = new PatientMedicalHistoryEntities1();
        }

        public AddEditPatientRecord(Patient recordToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Patient Record";
            this.Text = "Edit Patient Record";
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

        private void PopulateFields(Patient recordToEdit)
        {
            tbPatientFirstName.Text = recordToEdit.PatientFirstName.ToString();
            tbPatientLastName.Text = recordToEdit.PatientLastName.ToString();
            dtOfBirth.Value = (DateTime)recordToEdit.DateOfBirth;
            cbGender.SelectedItem = recordToEdit.Gender.ToString();
            tbAddress.Text = recordToEdit.Address.ToString();
            tbState.Text = recordToEdit.State.ToString();
            tbCity.Text = recordToEdit.City.ToString();
            tbZipCode.Text = recordToEdit.ZipCode.ToString();
            tbContactNumber.Text = recordToEdit.ContactNumber.ToString();
            tbEmail.Text = recordToEdit.Email.ToString();
            lblRecordId.Text = recordToEdit.PatientID.ToString();
            lblPatientName.Text = (string)recordToEdit.PatientFirstName + " " + recordToEdit.PatientLastName;


            //Selected DateOfBirth value
            var dob = (DateTime)recordToEdit.DateOfBirth;

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
                string FirstName = tbPatientFirstName.Text;
                string LastName = tbPatientLastName.Text;
                string Address = tbAddress.Text;
                string State = tbState.Text;
                string City = tbCity.Text;
                var Zip = tbZipCode.Text;
                var Number = tbContactNumber.Text;
                var Email = tbEmail.Text;


                var DOB = dtOfBirth.Value;
                var CurrentDate = DateTime.Today;
                var Gender = cbGender.SelectedItem;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName)
                   /* || string.IsNullOrWhiteSpace(Gender)*/ || string.IsNullOrWhiteSpace(Address)
                    || string.IsNullOrWhiteSpace(State)  || string.IsNullOrWhiteSpace(City) 
                    || string.IsNullOrWhiteSpace(Zip)    || string.IsNullOrWhiteSpace(Number) 
                    || string.IsNullOrWhiteSpace(Email))
                {
                    errorMessage += "Error: Please Enter Missing Data.\n\r";
                    isValid = false;
                }

                if (DOB > CurrentDate)
                {
                    errorMessage += "Error: Illegal Date Selection.\n\r";
                    isValid = false;
                }

                if (isValid)
                {
                    var PatientRecord = new Patient();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblRecordId.Text);
                        PatientRecord = _db.Patients.FirstOrDefault(q => q.PatientID == id);
                    }
                    //Populate record object with values from the form
                    PatientRecord.PatientFirstName = FirstName;
                    PatientRecord.PatientLastName = LastName;
                    PatientRecord.DateOfBirth = DOB;
                    PatientRecord.Gender = Convert.ToString(cbGender.SelectedItem);
                    PatientRecord.Address = Address;
                    PatientRecord.State = State;
                    PatientRecord.City = City;
                    PatientRecord.ZipCode = Convert.ToInt32(Zip);
                    PatientRecord.ContactNumber = Convert.ToInt32(Number);
                    PatientRecord.Email = Email;

                    //If not in edit mode, then add the record object to the database
                    if (!isEditMode)
                      _db.Patients.Add(PatientRecord);
                    

                    //Save changes made to the entity
                    _db.SaveChanges();


                    MessageBox.Show($"Customer Name: {FirstName} {LastName}" +
                                        $"\nDate of Birth: {DOB}" +
                                        $"\nGender: {Gender}" +
                                        $"\nAddress: {Address}, {State}" +
                                        $"\n               {City}, {Zip}" +
                                        $"\nContact Number: {Number}" +
                                        $"\nEmail: {Email}" +
                                        $"\nPATIENT RECORD UPDATED");
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
