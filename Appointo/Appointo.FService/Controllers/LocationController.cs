using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Appointo.Library.Models;

namespace Appointo.FService.Controllers
{
	[Produces("application/json")]
	[Route("api/[controller]")]
	public class LocationController : Controller
	{
		private LibHelper _db = new LibHelper();
		private List<Location> _locations = new List<Location>();

		[HttpGet]
		public HttpResponseMessage Get()

		{
			_locations = _db.ViewLocations();
			return Ok(_locations);
		}

		[HttpPost]
		public IActionResult Post([FromBody]Location location)
		{
			try
			{
				//				_locations.Add(new DB.Location());
				_db.AddLocation(location.RoomNumber);
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}
