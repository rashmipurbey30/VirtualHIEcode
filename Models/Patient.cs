//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualHIE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Patient
    {
        public Patient()
        {
            this.PatientDataAccesses = new HashSet<PatientDataAccess>();
            this.PatientDataRequests = new HashSet<PatientDataRequest>();
            this.PatientTreatmentDetails = new HashSet<PatientTreatmentDetail>();
        }
    
        public int Id { get; set; }
        [Display(Name = "Aadhar ID")]
        public string AadharId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string Name { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date of Birth")]
        public System.DateTime DateOfBirth { get; set; }
        [Display(Name = "Mobile Number")]
        public long MobileNumber { get; set; }
        [Display(Name = "Email ID")]
        public string EmailId { get; set; }
    
        public virtual ICollection<PatientDataAccess> PatientDataAccesses { get; set; }
        public virtual ICollection<PatientDataRequest> PatientDataRequests { get; set; }
        public virtual ICollection<PatientTreatmentDetail> PatientTreatmentDetails { get; set; }
    }
}
