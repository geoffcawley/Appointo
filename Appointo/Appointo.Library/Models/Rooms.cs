using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Appointo.Entity;

namespace Appointo.Library.Models
{
  public class Rooms
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public int RoomNumber { get; set; }

	public Rooms()
		{
			Id = -1;
			RoomNumber = -1;
		}
    public Rooms(Appointo.Entity.Rooms l)
    {
      Id = l.RoomId;
      RoomNumber = l.RoomNum;
    }

	public Rooms(int roomnum)
		{
			Id = -1;
			RoomNumber = roomnum;
		}
  }
}
