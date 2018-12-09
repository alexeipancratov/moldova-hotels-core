using MoldovaHotelsCore.GlobalWebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Services.Interfaces
{
    public interface IHotelService
    {
        Task<IEnumerable<Hotel>> GetHotelsAsync();

        Task<Hotel> GetHotelAsync(int hotelId);
    }
}
