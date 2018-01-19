using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class DoctorPatientAppointments
    {
        public int DoctorPatientAppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int AppointmentId { get; set; }

        public Appointments Appointment { get; set; }
        public Doctors Doctor { get; set; }
        public Patients Patient { get; set; }
    }
}
