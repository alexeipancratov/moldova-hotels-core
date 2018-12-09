using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MoldovaHotelsCore.SearchService.Engines.Interfaces;
using MoldovaHotelsCore.SearchService.Models;

namespace MoldovaHotelsCore.SearchService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelEngine hotelEngine;

        public HotelsController(IHotelEngine hotelEngine)
        {
            this.hotelEngine = hotelEngine;
        }

        // GET api/hotels
        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> Get()
        {
            return new JsonResult(hotelEngine.GetHotels());
        }

        // GET api/hotels/5
        [HttpGet("{id}")]
        public ActionResult<Hotel> Get(int id)
        {
            return hotelEngine.GetHotel(id);
        }
    }
}
