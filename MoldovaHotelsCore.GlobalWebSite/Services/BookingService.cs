using Microsoft.Extensions.Configuration;
using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Services
{
    public class BookingService : IBookingService
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;

        public BookingService(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
        }

        public async Task<decimal> CalculatePriceAsync(decimal baseRoomPrice, int numberOfAdults, int numberOfChildren)
        {
            Uri uri = new Uri($"{configuration.GetSection("Microservices")["BookingService"]}/api/bookings/price?baseRoomPrice={baseRoomPrice}&numberOfAdults={numberOfAdults}&numberOfChildren={numberOfChildren}");
            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);

            return await responseMessage.Content.ReadAsAsync<decimal>();
        }
    }
}
