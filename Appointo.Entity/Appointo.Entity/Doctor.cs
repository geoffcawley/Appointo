//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appointo.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doctor
    {
        public Doctor()
        {
            this.DoctorAppointments = new HashSet<DoctorAppointment>();
            this.Locations = new HashSet<Location>();
            this.Appointments = new HashSet<Appointment>();
        }
    
        public int Id { get; set; }
        public int LoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Specialty Specialty { get; set; }
    
        public virtual Login Login { get; set; }
        public virtual ICollection<DoctorAppointment> DoctorAppointments { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}