using Microsoft.AspNetCore.Mvc;
using MoldovaHotelsCore.GlobalWebSite.Models;
using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelService hotelService;

        public HotelsController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Hotel> hotels = await hotelService.GetHotelsAsync();

            return View(hotels);
        }

        public async Task<IActionResult> Show(int hotelId)
        {
            Hotel hotel = await hotelService.GetHotelAsync(hotelId);

            return View(hotel);
        }
    }
}