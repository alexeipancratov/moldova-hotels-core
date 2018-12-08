using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.GlobalWebSite.Services
{
    public class BookingService : IBookingService
    {
        private readonly HttpClient httpClient;

        public BookingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<decimal> CalculatePriceAsync(decimal baseRoomPrice, int numberOfAdults, int numberOfChildren)
        {
            Uri uri = new Uri($"http://mhotelscore.bookingservice:81/api/bookings/price?baseRoomPrice={baseRoomPrice}&numberOfAdults={numberOfAdults}&numberOfChildren={numberOfChildren}");
            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);

            return await responseMessage.Content.ReadAsAsync<decimal>();
        }
    }
}
