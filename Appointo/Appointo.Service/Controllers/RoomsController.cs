using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appointo.Library.Models;
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
		public IActionResult Post([FromBody]Rooms location)
		{
			try
			{
				//				_locations.Add(new DB.Location());
				_db.AddRoom(location.RoomNumber);
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
