using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
	public class Address
	{
		[Key]
		public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string AddressLine1 { get; set; }

		public string AddressLine2 { get; set; } //this is set to nullable in db

        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string City { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public int ZipCode = 0;

    public Address (Appointo.Entity.Addresses a)
    {
      Id = a.AddressId;
      AddressLine1 = a.AddressLine1;
      AddressLine2 = a.AddressLine2;
      City = a.City;
      State = a.State;
      ZipCode = a.ZipCode;
    }
	}
}