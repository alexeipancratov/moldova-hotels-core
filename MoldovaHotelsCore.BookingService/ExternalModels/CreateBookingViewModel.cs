using MoldovaHotelsCore.BookingService.Models;

namespace MoldovaHotelsCore.BookingService.ExternalModels
{
    public class CreateBookingViewModel
    {
        public string UserId { get; set; }

        public Booking Booking { get; set; }

        public CreditCardInformation CreditCardInformation { get; set; }
    }
}
