﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appointo.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataEntityModelContainer : DbContext
    {
        public DataEntityModelContainer()
            : base("name=DataEntityModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Receptionist> Receptionists { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<DoctorPatientAppointment> DoctorPatientAppointments { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
    }
}
