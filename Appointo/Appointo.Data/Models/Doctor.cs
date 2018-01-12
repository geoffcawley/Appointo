using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class Doctor
	{
		public Doctor()
		{
			this.DoctorAppointments = new HashSet<DoctorAppointment>();
			this.Locations = new HashSet<Location>();
			this.Appointments = new HashSet<Appointment>();
		}

		public int Id { get; set; }
		public int LoginId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Specialty Specialty { get; set; }

		public virtual Login Login { get; set; }
		public virtual ICollection<DoctorAppointment> DoctorAppointments { get; set; }
		public virtual ICollection<Location> Locations { get; set; }
		public virtual ICollection<Appointment> Appointments { get; set; }
	}
}
