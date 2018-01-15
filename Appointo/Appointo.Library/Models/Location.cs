using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
//using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Location
  {
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
    //also takes address class
  }
}
