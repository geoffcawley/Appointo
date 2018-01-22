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
    [Route("api/Doctor")]
    public class DoctorController : Controller
    {
		private LibHelper _db = new LibHelper();
		private List<Doctor> _doctors = new List<Doctor>();

		[HttpGet]
		public IActionResult Get()

		{
			_doctors = _db.ViewDoctors();
			return Ok(_doctors);
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody]Doctor doctor)
		{
			try
			{
				//_db.AddDoctors(doctor.DocFirstName, doctor.DocLastName, doctor.Specialty);
				//_doctors.Add(new Rooms(location.RoomNumber));
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}