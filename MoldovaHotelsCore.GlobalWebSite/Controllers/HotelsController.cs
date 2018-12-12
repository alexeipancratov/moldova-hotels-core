using Microsoft.AspNetCore.Mvc;
using MoldovaHotelsCore.GlobalWebSite.Models;
using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
using Polly.Bulkhead;
using Polly.Timeout;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Controllers
{
    public class HotelsController : Controller
    {
        private readonly ISearchService hotelService;

        public HotelsController(ISearchService hotelService)
        {
            this.hotelService = hotelService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Hotel> hotels = new List<Hotel>();

            try
            {
                hotels = await hotelService.GetHotelsAsync();
            }
            catch (TimeoutRejectedException)
            {
                ViewBag.ServiceUnavailable = true;
            }
            catch (BulkheadRejectedException)
            {
                ViewBag.TooManyUsers = true;
            }
            catch (Exception)
            {
                ViewBag.ServiceUnavailable = true;
            }

            return View(hotels);
        }

        public async Task<IActionResult> Show(int hotelId)
        {
            try
            {
                Hotel hotel = await hotelService.GetHotelAsync(hotelId);

                return View(hotel);
            }
            catch (Exception)
            {
                return View("Error", new ErrorViewModel());
            }
        }
    }
}