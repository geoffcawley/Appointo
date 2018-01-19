using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class Logins
    {
        public Logins()
        {
            Receptionists = new HashSet<Receptionists>();
        }

        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Receptionists> Receptionists { get; set; }
    }
}
