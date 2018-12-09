using Microsoft.AspNetCore.Mvc;
using MoldovaHotelsCore.GlobalWebSite.InteractionModels;
using MoldovaHotelsCore.GlobalWebSite.Models;
using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
using MoldovaHotelsCore.GlobalWebSite.ViewModels;
using System;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Controllers
{
    public class BookingsController : Controller
    {
        private readonly IBookingService bookingService;

        public BookingsController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TodayPrice = await bookingService.CalculatePriceAsync(50.75m, 2, 1);

            return View();
        }

        public IActionResult New(int roomId)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Make(NewBookingViewModel model)
        {
            var makeBooking = new CreateBookingInteractionModel
            {
                Booking = new Booking
                {
                    CheckIn = model.CheckIn,
                    CheckOut = model.CheckOut,
                    EmailAddress = model.EmailAddress,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    RoomId = model.RoomId,
                    TelephoneNumber = model.TelephoneNumber,
                    TotalPrice = 125.50m
                },
                CreditCardInformation = new CreditCardInformation
                {
                    CardNumber = model.CardNumber,
                    CardType = model.CardType,
                    ExpirationMonth = model.ExpiryMonth,
                    ExpirationYear = model.ExpiryYear,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    SecurityCode = model.SecurityCode
                },
                UserId = Guid.NewGuid().ToString()
            };

            Booking madeBooking = await bookingService.MakeBookingAsync(makeBooking);

            return View(madeBooking);
        }
    }
}