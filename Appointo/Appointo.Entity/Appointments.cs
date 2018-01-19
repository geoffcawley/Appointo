using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class Appointments
    {
        public Appointments()
        {
            DoctorPatientAppointments = new HashSet<DoctorPatientAppointments>();
        }

        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public Duration Duration { get; set; }
        public string Reason { get; set; }

        public ICollection<DoctorPatientAppointments> DoctorPatientAppointments { get; set; }
    }
}
