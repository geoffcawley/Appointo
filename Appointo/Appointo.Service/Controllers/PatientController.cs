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
    [Route("api/Patient")]
    public class PatientController : Controller
    {
		private LibHelper _db = new LibHelper();
		private List<Patient> _patients = new List<Patient>();

		[HttpGet]
		public IActionResult Get()
		{
			_patients = _db.ViewPatients();
			return Ok(_patients);
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody]Patient patient)
		{
			try
			{
				_db.AddPatients(patient.PatFirstName, patient.PatLastName, patient.DateofBirth, patient.AddressId);
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