using System;
using System.Collections.Generic;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  class Doctor
  {
    public int DoctorID = 0;
    public string DocFirstName { get; set; }
    public string DocLastName { get; set; }
    public string Speciality { get; set; }
    //also takes location
  }
}
