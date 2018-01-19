using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class Patients
    {
        public Patients()
        {
            DoctorPatientAppointments = new HashSet<DoctorPatientAppointments>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public int AddressId { get; set; }

        public Addresses Address { get; set; }
        public ICollection<DoctorPatientAppointments> DoctorPatientAppointments { get; set; }
    }
}
