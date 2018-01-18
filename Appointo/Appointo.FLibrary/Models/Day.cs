using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Day
  {
		[Key]
		public int Id { get; set; }
		DateTime PatientDateTime = DateTime.UtcNow;
  }
}
