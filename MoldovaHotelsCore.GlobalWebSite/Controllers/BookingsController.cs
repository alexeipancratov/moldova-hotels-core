using Microsoft.AspNetCore.Mvc;
using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
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
    }
}