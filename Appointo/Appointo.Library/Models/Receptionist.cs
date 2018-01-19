using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Receptionist
  {
		[Key]
		public int Id { get; set; }
		public int LoginId { get; set; }
    public string RecptFirstName { get; set; }
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
