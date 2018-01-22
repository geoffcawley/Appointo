using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;
using Appointo.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointo.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Appointment")]
    public class AppointmentController : Controller
    {
		private LibHelper _db = new LibHelper();
		private List<Appointment> _appointments = new List<Appointment>();

		[HttpGet]
		public IActionResult Get()

		{
			_appointments = _db.ViewAppointments();
			return Ok(_appointments);
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody]Appointment appointment)
		{
			try
			{
				_db.AddAppointment(appointment.StartTime, appointment.Duration, appointment.Reason);
				//_locations.Add(new Rooms(location.RoomNumber));
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}