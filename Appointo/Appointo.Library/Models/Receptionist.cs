using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Receptionist
  {
	[Key]
	public int Id { get; set; }

    [ForeignKey("Receptionist")]
	public int LoginId { get; set; }

    [Required]
    [StringLength(25, MinimumLength = 2)]
    public string RecptFirstName { get; set; }

    [Required]
    [StringLength(25, MinimumLength = 2)]
    public string RecptLastName { get; set; }

    public Receptionist (Appointo.Entity.Receptionists r)
    {
      Id = r.ReceptionistId;
      LoginId = r.LoginId;
      RecptFirstName = r.FirstName;
      RecptLastName = r.LastName;
    }
  }
}
