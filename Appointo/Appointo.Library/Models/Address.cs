using System;
using System.Collections.Generic;
using System.Text;
//using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Address
  {
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int ZipCode = 0;
  }
}