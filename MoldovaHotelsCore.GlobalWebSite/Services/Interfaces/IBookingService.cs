using MoldovaHotelsCore.GlobalWebSite.InteractionModels;
using MoldovaHotelsCore.GlobalWebSite.Models;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Services.Interfaces
{
    public interface IBookingService
    {
        Task<decimal> CalculatePriceAsync(decimal baseRoomPrice, int numberOfAdults, int numberOfChildren);

        Task<Booking> MakeBookingAsync(CreateBookingInteractionModel booking);
    }
}
