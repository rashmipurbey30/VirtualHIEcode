﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HealthInformationExchangeEntities : DbContext
    {
        public HealthInformationExchangeEntities()
            : base("name=HealthInformationExchangeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EnrollmentStatu> EnrollmentStatus { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientDataAccess> PatientDataAccesses { get; set; }
        public virtual DbSet<PatientDataRequest> PatientDataRequests { get; set; }
        public virtual DbSet<PatientDataRequestStatu> PatientDataRequestStatus { get; set; }
        public virtual DbSet<PatientTreatmentDetail> PatientTreatmentDetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
