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
	[Route("api/[controller]")]
	public class RoomsController : Controller
	{
		private LibHelper _db = new LibHelper();
		private List<Rooms> _locations = new List<Rooms>();

		[HttpGet]
		public IActionResult Get()

		{
			_locations = _db.ViewRooms();
			return Ok(_locations);
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody]Rooms location)
		{
			try
			{
				_db.AddRoom(location.RoomNumber);
				_locations.Add(new Rooms(location.RoomNumber));
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
