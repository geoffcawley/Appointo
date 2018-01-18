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
    public string DateofBirth { get; set; }
    //also takes address
  }
}
