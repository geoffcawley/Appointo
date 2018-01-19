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
    public string Specialty { get; set; }

    
    public Doctor(Appointo.Entity.Doctors d)
        {
            Id = d.DoctorId;
            DocFirstName = d.FirstName;
            DocLastName = d.LastName;
            Specialty = d.Specialty.ToString();
        }
  }
}
