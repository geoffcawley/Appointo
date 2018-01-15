using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
//using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Receptionist
  {
		[Key]
		public int Id { get; set; }
		public int RecptID = 0;
    public string RecptFirstName { get; set; }
    public string RecptLastName { get; set; }
    //also takes location
  }
}
