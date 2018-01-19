using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Patient
  {
	[Key]
	public int Id { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string PatFirstName { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string PatLastName { get; set; }

    [Required]
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    //[MyBirthDateValidation(ErrorMessage = "You cannot be from the Future!")]
    public int DateofBirth { get; set; }

    [ForeignKey("Address")]
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
