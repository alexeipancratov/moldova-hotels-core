using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoldovaHotelsCore.BookingService.Engines.Interfaces;
using MoldovaHotelsCore.BookingService.InteractionModels;
using MoldovaHotelsCore.BookingService.Models;

namespace MoldovaHotelsCore.BookingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingEngine bookingEngine;

        public BookingsController(IBookingEngine bookingEngine)
        {
            this.bookingEngine = bookingEngine;
        }

        // POST api/bookings
        [HttpPost]
        public async Task<ActionResult<Booking>> Post(CreateBookingInteractionModel viewModel)
        {
            return await bookingEngine.MakeBookingAsync(viewModel.UserId, viewModel.Booking, viewModel.CreditCardInformation);
        }

        // GET api/bookings/price
        [Route("price")]
        [HttpGet]
        public ActionResult<decimal> CalculatePrice(decimal baseRoomPrice, int numberOfAdults, int numberOfChildren)
        {
            return bookingEngine.CalculateRoomPrice(baseRoomPrice, numberOfAdults, numberOfChildren);
        }
    }
}
