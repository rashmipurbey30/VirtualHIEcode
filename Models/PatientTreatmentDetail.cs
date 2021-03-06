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
    
    public partial class PatientTreatmentDetail
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int HospitalId { get; set; }
        [Display(Name = "Medical History")]
        public string TreatmentDetails { get; set; }
        [Display(Name = "Reference Document")]
        public byte[] Files { get; set; }
        public int CreatedBy { get; set; }
        [Display(Name = "Treated on")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime CreatedOn { get; set; }
    
        public virtual Hospital Hospital { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
