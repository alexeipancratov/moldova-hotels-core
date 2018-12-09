using System.Collections.Generic;
using MoldovaHotelsCore.SearchService.Engines.Interfaces;
using MoldovaHotelsCore.SearchService.Models;

namespace MoldovaHotelsCore.SearchService.Engines
{
    public class HotelEngine : IHotelEngine
    {
        public Hotel GetHotel(int hotelId)
        {
            return new Hotel
            {
                HotelId = 12,
                Address = "str. Stefan cel Mare, 186",
                CheapestRoomPrice = 44.5m,
                Class = 4,
                Description = "The best hotel in Chisinau town",
                Name = "Kool Hotel",
                Rooms = new List<Room>
                {
                    new Room
                    {
                        Name = "Single Deluxe",
                        Price = 44.5m,
                        RoomId = 1
                    },
                    new Room
                    {
                        Name = "Double Twin",
                        Price = 55m,
                        RoomId = 2
                    }
                }
            };
        }

        public IEnumerable<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    HotelId = 12,
                    Address = "str. Stefan cel Mare, 186. Chisinau",
                    CheapestRoomPrice = 44.5m,
                    Class = 4,
                    Description = "The best hotel in Chisinau town",
                    Name = "Kool Hotel",
                    Rooms = new List<Room>
                    {
                        new Room
                        {
                            Name = "Single Deluxe",
                            Price = 44.5m,
                            RoomId = 1
                        },
                        new Room
                        {
                            Name = "Double Twin",
                            Price = 55m,
                            RoomId = 2
                        }
                    }
                },
                new Hotel
                {
                    HotelId = 15,
                    Address = "str. Stefan cel Mare, 186. Chisinau",
                    CheapestRoomPrice = 74.5m,
                    Class = 5,
                    Description = "The best hotel in Chisinau town",
                    Name = "Another Kool Hotel",
                    Rooms = new List<Room>
                    {
                        new Room
                        {
                            Name = "Single Deluxe",
                            Price = 44.5m,
                            RoomId = 1
                        },
                        new Room
                        {
                            Name = "Double Twin",
                            Price = 55m,
                            RoomId = 2
                        }
                    }
                },
            };
        }
    }
}
