using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class Appointment
	{
		public Appointment()
		{
			this.Receptionists = new HashSet<Receptionist>();
		}

		public int Id { get; set; }
		public System.DateTime Date { get; set; }
		public int Duration { get; set; }
		public string Reason { get; set; }
		public Nullable<int> DoctorId { get; set; }
		public Nullable<int> PatientId { get; set; }

		public virtual Doctor Doctor { get; set; }
		public virtual Patient Patient { get; set; }
		public virtual ICollection<Receptionist> Receptionists { get; set; }
	}
}
