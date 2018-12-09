using MoldovaHotelsCore.BookingService.Models;

namespace MoldovaHotelsCore.BookingService.InteractionModels
{
    public class CreateBookingInteractionModel
    {
        public string UserId { get; set; }

        public Booking Booking { get; set; }

        public CreditCardInformation CreditCardInformation { get; set; }
    }
}
