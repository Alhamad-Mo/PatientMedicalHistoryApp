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
    public partial class Demographics : Form
    {
        private readonly PatientMedicalHistoryEntities1 _db;
        bool searchBox = false;
        public Demographics()
        {
            InitializeComponent();
            _db = new PatientMedicalHistoryEntities1();

        }

        public Demographics(int id, string name, int age)
        {
            InitializeComponent();
            _db = new PatientMedicalHistoryEntities1();
            var records = _db.GeneralMedicalHistories.Where(p => p.C_PatientID == id).Select(q => new
            {
                    GeneralID = q.GeneralMedicalHistoryID,
                    PatientID = q.C_PatientID,
                    MaritalStatus = q.MartialStatus,
                    Education = q.Education,
                    BloodType = q.BloodType,
                    Pregenancies = q.Pregnancies,
                    Tobacco = q.Tobacco,
                    Alcohol = q.Alcohol,
                    Drug = q.Drug,
                    MedicalHistoryNotes = q.MedicalHistoryNotes,

            }).ToList();


            gvDemographics.DataSource = records;
            gvDemographics.Columns["MaritalStatus"].HeaderText = "Marital Status";
            gvDemographics.Columns["BloodType"].HeaderText = "Blood Type";
            gvDemographics.Columns["MedicalHistoryNotes"].HeaderText = "Medical History Notes";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvDemographics.Columns["GeneralID"].Visible = false;

            lblPatientName.Text = name;
            lblPatientAge.Text = age.ToString();
        }

        private void Demographics_Load(object sender, EventArgs e)
        {
            try
            {
                gvDemographics.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void PopulateGrid()
        {
            var records = _db.GeneralMedicalHistories.Select(q => new
            {
                GeneralID = q.GeneralMedicalHistoryID,
                PatientID = q.C_PatientID,
                MaritalStatus = q.MartialStatus,
                Education = q.Education,
                BloodType = q.BloodType,
                Pregenancies = q.Pregnancies,
                Tobacco = q.Tobacco,
                Alcohol = q.Alcohol,
                Drug = q.Drug,
                MedicalHistoryNotes = q.MedicalHistoryNotes,
            }).ToList();


            gvDemographics.DataSource = records;
            gvDemographics.Columns["MaritalStatus"].HeaderText = "Marital Status";
            gvDemographics.Columns["BloodType"].HeaderText = "Blood Type";
            gvDemographics.Columns["MedicalHistoryNotes"].HeaderText = "Medical History Notes";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvDemographics.Columns["GeneralID"].Visible = false;

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            var addEditDemographicRecord = new AddEditDemographics();
            addEditDemographicRecord.ShowDialog();
            addEditDemographicRecord.MdiParent = this.MdiParent;

        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvDemographics.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.GeneralMedicalHistories.FirstOrDefault(q => q.C_PatientID == id);

                //Launch AddEditPatient Window With Data
                var AddEditDemographicRecord = new AddEditDemographics(record);
                AddEditDemographicRecord.MdiParent = this.MdiParent;
                AddEditDemographicRecord.ShowDialog();


                gvDemographics.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvDemographics.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.GeneralMedicalHistories.FirstOrDefault(q => q.C_PatientID == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Patient?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Patient Listing
                    _db.GeneralMedicalHistories.Remove(record);
                    _db.SaveChanges();
                }
                PopulateGrid();
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

        private void btnViewAllergyHistory_Click(object sender, EventArgs e)
        {
            try
            {
                //Get PatientID from selected row. Compare it to FK from _db.AllergyHistories
                var id = (int)gvDemographics.SelectedRows[0].Cells["PatientID"].Value;
                var record = _db.AllergyHistories.FirstOrDefault(q => q.C_PatientID == id);


                //Selected PatientFirstName & PatientLastName value to lblPatientName label
                var name = _db.Patients.FirstOrDefault(q => q.PatientID == id);
                lblPatientName.Text = name.ToString();
                var p = name.PatientFirstName + " " + name.PatientLastName;

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
                var viewMedicalHistory = new Allergy(id, p, age);
                viewMedicalHistory.MdiParent = this.MdiParent;
                viewMedicalHistory.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            gvDemographics.DataSource = _db.GeneralMedicalHistories.Where(x => x.C_PatientID.ToString().Contains(tbSearch.Text)
                    || x.Patient.ContactNumber.ToString().Contains(tbSearch.Text)
                    || x.Patient.PatientLastName.Contains(tbSearch.Text)).Select(q => new
                    {
                        GeneralID = q.GeneralMedicalHistoryID,
                        PatientID = q.C_PatientID,
                        MaritalStatus = q.MartialStatus,
                        Education = q.Education,
                        BloodType = q.BloodType,
                        Pregenancies = q.Pregnancies,
                        Tobacco = q.Tobacco,
                        Alcohol = q.Alcohol,
                        Drug = q.Drug,
                        MedicalHistoryNotes = q.MedicalHistoryNotes,

                    }).ToList();

            gvDemographics.Columns["MaritalStatus"].HeaderText = "Marital Status";
            gvDemographics.Columns["BloodType"].HeaderText = "Blood Type";
            gvDemographics.Columns["MedicalHistoryNotes"].HeaderText = "Medical History Notes";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvDemographics.Columns["GeneralID"].Visible = false;

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
