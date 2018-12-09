using System.Collections.Generic;

namespace MoldovaHotelsCore.GlobalWebSite.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }

        public string Name { get; set; }

        public byte Class { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public decimal CheapestRoomPrice { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }
}
