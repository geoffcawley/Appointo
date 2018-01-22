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
    [Route("api/Address")]
    public class AddressController : Controller
    {
		private LibHelper _db = new LibHelper();
		private List<Address> _addresses = new List<Address>();

		[HttpGet]
		public IActionResult Get()

		{
			_addresses = _db.ViewAddress();
			return Ok(_addresses);
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody]Address address)
		{
			try
			{
				_db.AddAddress(address.AddressLine1, address.AddressLine2, address.City, address.State, address.ZipCode);
				//_addresses.Add(new Rooms(location.RoomNumber));
				return Ok();
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}