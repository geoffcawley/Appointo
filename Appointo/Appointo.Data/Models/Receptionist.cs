using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class Receptionist
	{
		public Receptionist()
		{
			this.Appointments = new HashSet<Appointment>();
		}

		public int Id { get; set; }
		public int LoginId { get; set; }

		public virtual Login Login { get; set; }
		public virtual ICollection<Appointment> Appointments { get; set; }
	}
}
