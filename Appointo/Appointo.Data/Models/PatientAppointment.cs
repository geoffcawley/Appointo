using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class PatientAppointment
	{
		public int Id { get; set; }
		public Nullable<int> PatientId { get; set; }

		public virtual Patient Patient { get; set; }
	}
}
