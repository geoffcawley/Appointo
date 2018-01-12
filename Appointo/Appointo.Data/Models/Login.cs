using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class Login
	{
		public Login()
		{
			this.Patients = new HashSet<Patient>();
			this.Doctors = new HashSet<Doctor>();
			this.Receptionists = new HashSet<Receptionist>();
		}

		public int Id { get; set; }

		public virtual ICollection<Patient> Patients { get; set; }
		public virtual ICollection<Doctor> Doctors { get; set; }
		public virtual ICollection<Receptionist> Receptionists { get; set; }
	}
}
