using System;
using System.Collections.Generic;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  class Appointment
  {
    DateTime StartTime = DateTime.UtcNow;
    public int Duration = 0; //should this be an int? should just be an option between 30 and 60 min
    public string Reason { get; set; }
    //needs Doctor, Receptionist, Date, Patient, and Location
  }
}
