//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatientMedicalHistoryApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class GeneralMedicalHistory
    {
        public int GeneralMedicalHistoryID { get; set; }
        public string MartialStatus { get; set; }
        public string Education { get; set; }
        public string BloodType { get; set; }
        public string Pregnancies { get; set; }
        public string Tobacco { get; set; }
        public string Alcohol { get; set; }
        public string Drug { get; set; }
        public string MedicalHistoryNotes { get; set; }
        public int C_PatientID { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
