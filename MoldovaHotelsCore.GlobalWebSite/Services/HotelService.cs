using MoldovaHotelsCore.GlobalWebSite.Models;
using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Services
{
    public class HotelService : IHotelService
    {
        private readonly HttpClient httpClient;

        public HotelService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Hotel> GetHotelAsync(int hotelId)
        {
            HttpResponseMessage responseMessage = await httpClient.GetAsync($"/api/hotels/{hotelId}");

            return await responseMessage.Content.ReadAsAsync<Hotel>();
        }

        public async Task<IEnumerable<Hotel>> GetHotelsAsync()
        {
            HttpResponseMessage responseMessage = await httpClient.GetAsync("/api/hotels");

            return await responseMessage.Content.ReadAsAsync<IEnumerable<Hotel>>();
        }
    }
}
