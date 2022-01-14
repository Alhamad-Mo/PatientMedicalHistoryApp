using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PatientMedicalHistoryApp
{
    public partial class PatientsList : Form
    {
        private readonly PatientMedicalHistoryEntities1 _db;
        bool searchBox = false;
        public PatientsList()
        {
            InitializeComponent();
            _db = new PatientMedicalHistoryEntities1();
        }

        private void PatientsList_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
                gvPatients.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void PopulateGrid()
        {

            var records = _db.Patients.Select(q => new
            {
                PatientID = q.PatientID,
                PatientFirstName = q.PatientFirstName,
                PatientLastName = q.PatientLastName,
                DateOfBirth = q.DateOfBirth,
                Gender = q.Gender,
                Address = q.Address,
                State = q.State,
                City = q.City,
                ZipCode = q.ZipCode,
                ContactNumber = q.ContactNumber,
                Email = q.Email,
            }).ToList();

            gvPatients.DataSource = records;
            gvPatients.Columns["PatientFirstName"].HeaderText = "First Name";
            gvPatients.Columns["PatientLastName"].HeaderText = "Last Name";
            gvPatients.Columns["DateOfBirth"].HeaderText = "DOB";
            gvPatients.Columns["ZipCode"].HeaderText = "Zip Code";
            gvPatients.Columns["ContactNumber"].HeaderText = "Contact Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvPatients.Columns["PatientID"].Visible = true;


        }
        private void btnAddPatient_Click_1(object sender, EventArgs e)
        {
            var addEditPatientRecord = new AddEditPatientRecord();
            addEditPatientRecord.ShowDialog();
            addEditPatientRecord.MdiParent = this.MdiParent;
        }
        private void btnEditPatient_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvPatients.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.Patients.FirstOrDefault(q => q.PatientID == id);

                //Launch AddEditPatient Window With Data
                var AddEditPatientRecord = new AddEditPatientRecord(record);
                AddEditPatientRecord.ShowDialog();
                AddEditPatientRecord.MdiParent = this.MdiParent;

                gvPatients.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void btnDeletePatient_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvPatients.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.Patients.FirstOrDefault(q => q.PatientID == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Patient?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Patient Listing
                    _db.Patients.Remove(record);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnViewMedicalHistory_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                //Get PatientID from selected row. Compare it to FK from _db.AllergyHistories
                var id = (int)gvPatients.SelectedRows[0].Cells["PatientID"].Value;
                var record = _db.Patients.FirstOrDefault(q => q.PatientID == id);


                //Selected PatientFirstName & PatientLastName value to lblPatientName label
                var name = record.PatientFirstName + " " + record.PatientLastName;
                lblPatientName.Text = name.ToString();
  

                //Selected DateOfBirth value
                var date = _db.Patients.FirstOrDefault(q => q.PatientID == id);
                lblPatientAge.Text = date.DateOfBirth.ToString();

                var dob = (DateTime)date.DateOfBirth;

                //Save today's date.
                var today = DateTime.Today;

                //Calculate the age.
                var age = today.Year - dob.Year;

                //Go back to the year in which the person was born in case of a leap year
                if (dob.Date > today.AddYears(-age)) age--;

                //Convert age to string and display it in label lblPatientAge
                lblPatientAge.Text = age.ToString();

                //Pass PatientID, PatientFirstName, PatientLastName, DateOfBirth to Allergy form
                var viewMedicalHistory = new Demographics(id, name, age);
                viewMedicalHistory.MdiParent = this.MdiParent;
                viewMedicalHistory.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void btnPatientHistory_Click(object sender, EventArgs e)
        {
            try
            {
                //Get PatientID from selected row. Compare it to FK from _db.AllergyHistories
                var id = (int)gvPatients.SelectedRows[0].Cells["PatientID"].Value;
                var record = _db.Patients.FirstOrDefault(q => q.PatientID == id);


                //Selected PatientFirstName & PatientLastName value to lblPatientName label
                var name = record.PatientFirstName + " " + record.PatientLastName;
                lblPatientName.Text = name.ToString();


                //Selected DateOfBirth value
                var date = _db.Patients.FirstOrDefault(q => q.PatientID == id);
                lblPatientAge.Text = date.DateOfBirth.ToString();

                var dob = (DateTime)date.DateOfBirth;

                //Save today's date.
                var today = DateTime.Today;

                //Calculate the age.
                var age = today.Year - dob.Year;

                //Go back to the year in which the person was born in case of a leap year
                if (dob.Date > today.AddYears(-age)) age--;

                //Convert age to string and display it in label lblPatientAge
                lblPatientAge.Text = age.ToString();

                //Pass PatientID, PatientFirstName, PatientLastName, DateOfBirth to Allergy form
                var viewPatientHistory = new pHistory(id, name, age);
                viewPatientHistory.MdiParent = this.MdiParent;
                viewPatientHistory.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnPatientAllergies_Click(object sender, EventArgs e)
        {
            try
            {
                //Get PatientID from selected row. Compare it to FK from _db.AllergyHistories
                var id = (int)gvPatients.SelectedRows[0].Cells["PatientID"].Value;
                var record = _db.Patients.FirstOrDefault(q => q.PatientID == id);


                //Selected PatientFirstName & PatientLastName value to lblPatientName label
                var name = record.PatientFirstName + " " + record.PatientLastName;
                lblPatientName.Text = name.ToString();


                //Selected DateOfBirth value
                var date = _db.Patients.FirstOrDefault(q => q.PatientID == id);
                lblPatientAge.Text = date.DateOfBirth.ToString();

                var dob = (DateTime)date.DateOfBirth;

                //Save today's date.
                var today = DateTime.Today;

                //Calculate the age.
                var age = today.Year - dob.Year;

                //Go back to the year in which the person was born in case of a leap year
                if (dob.Date > today.AddYears(-age)) age--;

                //Convert age to string and display it in label lblPatientAge
                lblPatientAge.Text = age.ToString();

                //Pass PatientID, PatientFirstName, PatientLastName, DateOfBirth to Allergy form
                var viewPatientAllergies = new Allergy(id, name, age);
                viewPatientAllergies.MdiParent = this.MdiParent;
                viewPatientAllergies.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            gvPatients.DataSource = _db.Patients.Where(x => x.PatientID.ToString().Contains(tbSearch.Text)
                    || x.ContactNumber.ToString().Contains(tbSearch.Text)
                    || x.PatientLastName.Contains(tbSearch.Text)).Select(q => new
                    {
                        PatientID = q.PatientID,
                        PatientFirstName = q.PatientFirstName,
                        PatientLastName = q.PatientLastName,
                        DateOfBirth = q.DateOfBirth,
                        Gender = q.Gender,
                        Address = q.Address,
                        State = q.State,
                        City = q.City,
                        ZipCode = q.ZipCode,
                        ContactNumber = q.ContactNumber,
                        Email = q.Email,
                    }).ToList();

            gvPatients.Columns["PatientFirstName"].HeaderText = "First Name";
            gvPatients.Columns["PatientLastName"].HeaderText = "Last Name";
            gvPatients.Columns["DateOfBirth"].HeaderText = "DOB";
            gvPatients.Columns["ZipCode"].HeaderText = "Zip Code";
            gvPatients.Columns["ContactNumber"].HeaderText = "Contact Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvPatients.Columns["PatientID"].Visible = true;
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            searchBox = true;

            if (tbSearch.Text == "Enter Search Text")
            {
                if (searchBox == true)
                {
                    tbSearch.Text = "";
                }
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Enter Search Text";
                PopulateGrid();
            }
        }

    }

}
