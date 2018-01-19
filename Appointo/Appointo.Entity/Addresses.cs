using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class Addresses
    {
        public Addresses()
        {
            Patients = new HashSet<Patients>();
        }

        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public ICollection<Patients> Patients { get; set; }
    }
}
