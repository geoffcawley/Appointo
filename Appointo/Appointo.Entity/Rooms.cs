using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class Rooms
    {
        public Rooms()
        {
            DoctorRooms = new HashSet<DoctorRooms>();
        }

        public int RoomId { get; set; }
        public int RoomNum { get; set; }

        public ICollection<DoctorRooms> DoctorRooms { get; set; }
    }
}
