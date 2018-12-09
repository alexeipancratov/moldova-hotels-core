using MoldovaHotelsCore.SearchService.Models;
using System.Collections.Generic;

namespace MoldovaHotelsCore.SearchService.Engines.Interfaces
{
    public interface IHotelEngine
    {
        IEnumerable<Hotel> GetHotels();

        Hotel GetHotel(int hotelId);
    }
}
