//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Text;
////using Appointo.Entity;

//namespace Appointo.Library.Models
//{
//	public class Appointment
//	{
//		[Key]
//		public int Id { get; set; }
//		DateTime StartTime = DateTime.UtcNow;
//		public int Duration = 0; //should this be an int? should just be an option between 30 and 60 min
//		public string Reason { get; set; }
//		//needs Doctor, Receptionist, Date, Patient, and Location

//		public Appointment(Appointo.Entity.Appointment a)
//		{
//			Id = a.Id;
//			StartTime = a.Date;
//			Duration = a.Duration;
//			Reason = a.Reason;
//		}
//	}
//}
