using System;
using System.Collections.Generic;

namespace Appointo.Entity
{
    public partial class DoctorRooms
    {
        public int DoctorRoomsId { get; set; }
        public int DoctorId { get; set; }
        public int RoomId { get; set; }

        public Doctors Doctor { get; set; }
        public Rooms Room { get; set; }
    }
}
