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
    
    public partial class Appointment
    {
        public Appointment()
        {
            this.Receptionists = new HashSet<Receptionist>();
            this.DoctorPatientAppointments = new HashSet<DoctorPatientAppointment>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public int Duration { get; set; }
        public string Reason { get; set; }
    
        public virtual ICollection<Receptionist> Receptionists { get; set; }
        public virtual ICollection<DoctorPatientAppointment> DoctorPatientAppointments { get; set; }
    }
}
