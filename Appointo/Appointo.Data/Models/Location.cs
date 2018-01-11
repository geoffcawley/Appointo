using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public partial class Location
	{
		public Location()
		{
			this.Doctors = new HashSet<Doctor>();
		}

		public int Id { get; set; }

		public virtual ICollection<Doctor> Doctors { get; set; }
	}
}
