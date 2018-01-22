using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
	public class Appointment
	{
		[Key]
		public int Id { get; set; }
		public DateTime StartTime { get; set; }
		public Duration Duration { get; set; }
		public string Reason { get; set; }

		public Appointment(Appointo.Entity.Appointments a)
		{
			Id = a.AppointmentId;
			StartTime = a.Date;
			Duration = a.Duration;
			Reason = a.Reason;
		}

		public Appointment()
		{

		}
	}
}
