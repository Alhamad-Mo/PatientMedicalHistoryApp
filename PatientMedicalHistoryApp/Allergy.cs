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
    public partial class Allergy : Form
    {
        private readonly PatientMedicalHistoryEntities1 _db;
        bool searchBox = false;
        public Allergy()
        {
            InitializeComponent();
            _db = new PatientMedicalHistoryEntities1();
        }
        public Allergy(int id, string name, int age)
        {
            InitializeComponent();
            _db = new PatientMedicalHistoryEntities1();
            var records = _db.AllergyHistories.Where(p => p.C_PatientID == id).Select(q => new
            {
                GeneralID = q.AllergyID,
                PatientID = q.C_PatientID,
                Allergen = q.Allergen,
                AllergyDescription = q.AllergyDescription,

            }).ToList();

            gvAllergies.DataSource = records;
            gvAllergies.Columns["AllergyDescription"].HeaderText = "Allergy Description";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvAllergies.Columns["GeneralID"].Visible = false;

            lblPatientName.Text = name.ToString();
            lblPatientAge.Text = age.ToString();
        }
        private void Allergy_Load(object sender, EventArgs e)
        {
            try
            {
                gvAllergies.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateGrid()
        {

            //var id = (int)gvAllergies.SelectedRows[0].Cells["PatientID"].Value;

            var records = _db.AllergyHistories.Select(q => new
            {
                GeneralID = q.AllergyID,
                PatientNumber = q.C_PatientID,
                Allergen = q.Allergen,
                AllergyDescription = q.AllergyDescription,

            }).ToList();

            gvAllergies.DataSource = records;
            gvAllergies.Columns["AllergyDescription"].HeaderText = "Allergy Description";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvAllergies.Columns["GeneralID"].Visible = false;

        }

        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            var addEditAllergyicRecord = new AddEditAllergy();
            addEditAllergyicRecord.ShowDialog();
            addEditAllergyicRecord.MdiParent = this.MdiParent;
        }

        private void btnEditAllergy_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvAllergies.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.AllergyHistories.FirstOrDefault(q => q.C_PatientID == id);

                //Launch AddEditPatient Window With Data
                var addEditAllergyicRecord = new AddEditAllergy(record);
                addEditAllergyicRecord.MdiParent = this.MdiParent;
                addEditAllergyicRecord.ShowDialog();

                gvAllergies.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteAllergy_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Id of Selected Row
                var id = (int)gvAllergies.SelectedRows[0].Cells["PatientID"].Value;

                //Query Our Database for Record
                var record = _db.AllergyHistories.FirstOrDefault(q => q.C_PatientID == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Patient?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Delete Patient Listing
                    _db.AllergyHistories.Remove(record);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnPatientHistory_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            gvAllergies.DataSource = _db.AllergyHistories.Where(x => x.C_PatientID.ToString().Contains(tbSearch.Text)
                   || x.Patient.ContactNumber.ToString().Contains(tbSearch.Text)
                   || x.Patient.PatientLastName.Contains(tbSearch.Text)).Select(q => new
                   {
                       GeneralID = q.AllergyID,
                       PatientID = q.C_PatientID,
                       Allergen = q.Allergen,
                       AllergyDescription = q.AllergyDescription,

                   }).ToList();

            gvAllergies.Columns["AllergyDescription"].HeaderText = "Allergy Description";
            //Hide the column for ID.Changed from the hard coded column value to the name,
            // to make it more dynamic.
            gvAllergies.Columns["GeneralID"].Visible = false;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
