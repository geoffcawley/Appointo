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
    public int RoomNumber { get; set; }

    public Rooms(Appointo.Entity.Rooms l)
    {
      Id = l.RoomId;
      RoomNumber = l.RoomNum;
    }
  }
}
