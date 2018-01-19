using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class Doctors
    {
        public Doctors()
        {
            DoctorPatientAppointments = new HashSet<DoctorPatientAppointments>();
            DoctorRooms = new HashSet<DoctorRooms>();
        }

        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Specialty Specialty { get; set; }

        public ICollection<DoctorPatientAppointments> DoctorPatientAppointments { get; set; }
        public ICollection<DoctorRooms> DoctorRooms { get; set; }
    }
}
