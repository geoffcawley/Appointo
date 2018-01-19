using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class Receptionists
    {
        public int ReceptionistId { get; set; }
        public int LoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Logins Login { get; set; }
    }
}
