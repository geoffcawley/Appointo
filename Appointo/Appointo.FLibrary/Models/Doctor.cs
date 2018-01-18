using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Doctor
  {
		[Key]
		public int Id { get; set; }
    public string DocFirstName { get; set; }
    public string DocLastName { get; set; }
    public string Speciality { get; set; }
  }
}
