using MoldovaHotelsCore.BookingService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.BookingService.Engines.Interfaces
{
    public interface IBookingEngine
    {
        decimal CalculateRoomPrice(int roomId, int numberOfAdults, int numberOfChildren);

        decimal CalculateRoomPrice(decimal baseRoomPrice, int numberOfAdults, int numberOfChildren);

        Task<Booking> MakeBookingAsync(string userId, Booking booking, CreditCardInformation creditCardInformation);

        List<BookingForUser> GetBookingsForUser(string userId, string language);

        Task UpdateBooking(EditBookingModel editBookingModel);

        Task<byte[]> GetBookingRowVersionFromApi(int localBookingId);

        Task CancelBooking(string userId, int bookingId);
    }
}
