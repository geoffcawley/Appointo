using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class DoctorPatientAppointment
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public int DocId { get; set; }
    [Required]
    public int PatId { get; set; }
    [Required]
    public int AppointId { get; set; }

    public DoctorPatientAppointment()
    {

    }

    public DoctorPatientAppointment(Appointo.Entity.DoctorPatientAppointments d)
    {
      Id = d.DoctorPatientAppointmentId;
      DocId = d.DoctorId;
      PatId = d.PatientId;
      AppointId = d.AppointmentId;
    }
  }
}
