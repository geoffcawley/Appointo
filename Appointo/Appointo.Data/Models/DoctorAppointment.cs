using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class DoctorAppointment
	{
		public int Id { get; set; }
		public Nullable<int> DoctorId { get; set; }

		public virtual Doctor Doctor { get; set; }
	}
}
