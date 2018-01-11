using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class Patient
	{
		public Patient()
		{
			this.Appointments = new HashSet<Appointment>();
			this.PatientAppointments = new HashSet<PatientAppointment>();
		}

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string DateOfBirth { get; set; }
		public string Address { get; set; }
		public int LoginId { get; set; }

		public virtual Login Login { get; set; }
		public virtual ICollection<Appointment> Appointments { get; set; }
		public virtual ICollection<PatientAppointment> PatientAppointments { get; set; }
	}
}
