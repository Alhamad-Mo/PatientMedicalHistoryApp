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
    public partial class pHistory : Form
    {
        private readonly PatientMedicalHistoryEntities1 _db;
        bool searchBox = false;
        public pHistory()
        {
            InitializeComponent();
            _db = new PatientMedicalHistoryEntities1();
        }
        public pHistory(int id, string name, int age)
        {
            InitializeComponent();
            _db = new PatientMedicalHistoryEntities1();
            var records = _db.PatientHistories.Where(p => p.C_PatientID == id).Select(q => new
            {
                HistoryID = q.MedicalHistoryID,
                PatientID = q.C_PatientID,
                DiseaseHistory = q.DiseaseHistory,
                SurgeryHistory = q.SurgeryHistory,
                MenstrualHistory = q.MenstrualHistory,
            }).ToList();

            gvPatientHistory.DataSource = records;
            gvPatientHistory.Columns["DiseaseHistory"].HeaderText = "Disease History";
            gvPatientHistory.Columns["SurgeryHistory"].HeaderText = "Surgery History";
            gvPatientHistory.Columns["MenstrualHistory"].HeaderText = "Menstrual History";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvPatientHistory.Columns["HistoryID"].Visible = false;

            lblPatientName.Text = name;
            lblPatientAge.Text = age.ToString();
        }
        private void pHistory_Load(object sender, EventArgs e)
        {
            try
            {
                gvPatientHistory.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void PopulateGrid()
        {
            var records = _db.PatientHistories.Select(q => new
            {
                HistoryID = q.MedicalHistoryID,
                PatientID = q.C_PatientID,
                DiseaseHistory = q.DiseaseHistory,
                SurgeryHistory = q.SurgeryHistory,
                MenstrualHistory = q.MenstrualHistory,
            }).ToList();

            gvPatientHistory.DataSource = records;
            gvPatientHistory.Columns["DiseaseHistory"].HeaderText = "Disease History";
            gvPatientHistory.Columns["SurgeryHistory"].HeaderText = "Surgery History";
            gvPatientHistory.Columns["MenstrualHistory"].HeaderText = "Menstrual History";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvPatientHistory.Columns["HistoryID"].Visible = false;
        }

        private void btnAddHistory_Click(object sender, EventArgs e)
        {
            var addEditHistoryRecord = new AddEditHistory();
            addEditHistoryRecord.ShowDialog();
            addEditHistoryRecord.MdiParent = this.MdiParent;
        }

        private void btnEditHistory_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvPatientHistory.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.PatientHistories.FirstOrDefault(q => q.C_PatientID == id);

                //Launch AddEditPatient Window With Data
                var AddEditHistoryRecord = new AddEditHistory(record);
                AddEditHistoryRecord.MdiParent = this.MdiParent;
                AddEditHistoryRecord.ShowDialog();


                gvPatientHistory.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteHistory_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvPatientHistory.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.PatientHistories.FirstOrDefault(q => q.C_PatientID == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Patient?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Patient Listing
                    _db.PatientHistories.Remove(record);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnViewMedicalHistory_Click(object sender, EventArgs e)
        {
            try
            {
                //Get PatientID from selected row. Compare it to FK from _db.PatientHistories
                var id = (int)gvPatientHistory.SelectedRows[0].Cells["PatientID"].Value;
                var record = _db.PatientHistories.FirstOrDefault(q => q.C_PatientID == id);


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
                var viewMedicalHistory = new Demographics(id, p, age);
                viewMedicalHistory.MdiParent = this.MdiParent;
                viewMedicalHistory.ShowDialog();
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
                var id = (int)gvPatientHistory.SelectedRows[0].Cells["PatientID"].Value;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            gvPatientHistory.DataSource = _db.PatientHistories.Where(x => x.C_PatientID.ToString().Contains(tbSearch.Text)
                    || x.Patient.ContactNumber.ToString().Contains(tbSearch.Text)
                    || x.Patient.PatientLastName.Contains(tbSearch.Text)).Select(q => new
                    {
                        HistoryID = q.MedicalHistoryID,
                        PatientID = q.C_PatientID,
                        DiseaseHistory = q.DiseaseHistory,
                        SurgeryHistory = q.SurgeryHistory,
                        MenstrualHistory = q.MenstrualHistory,

                    }).ToList();

            gvPatientHistory.Columns["DiseaseHistory"].HeaderText = "Disease History";
            gvPatientHistory.Columns["SurgeryHistory"].HeaderText = "Surgery History";
            gvPatientHistory.Columns["MenstrualHistory"].HeaderText = "Menstrual History";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvPatientHistory.Columns["HistoryID"].Visible = false;
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
