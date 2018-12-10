using MoldovaHotelsCore.GlobalWebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Services.Interfaces
{
    public interface ISearchService
    {
        Task<IEnumerable<Hotel>> GetHotelsAsync();

        Task<Hotel> GetHotelAsync(int hotelId);
    }
}
