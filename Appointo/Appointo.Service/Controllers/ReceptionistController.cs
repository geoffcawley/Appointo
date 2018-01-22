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
    [Route("api/Receptionist")]
    public class ReceptionistController : Controller
    {
		private LibHelper _db = new LibHelper();
		private List<Receptionist> _receptionists = new List<Receptionist>();

		[HttpGet]
		public IActionResult Get()
		{
			_receptionists = _db.ViewReceptionist();
			return Ok(_receptionists);
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody]Receptionist receptionist)
		{
			try
			{
				_db.AddReceptionist(receptionist.LoginId, receptionist.RecptFirstName, receptionist.RecptLastName);
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