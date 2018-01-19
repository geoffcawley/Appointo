using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Patient
  {
		[Key]
		public int Id { get; set; }
		public string PatFirstName { get; set; }
    public string PatLastName { get; set; }
    public int DateofBirth { get; set; }
    public int AddressId { get; set; } //take from addresses

    public Patient (Appointo.Entity.Patients p)
    {
      Id = p.PatientId;
      PatFirstName = p.FirstName;
      PatLastName = p.LastName;
      DateofBirth = p.DateOfBirth;
      AddressId = p.AddressId;
    }
  }
}
