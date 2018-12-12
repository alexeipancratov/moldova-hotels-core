using MoldovaHotelsCore.GlobalWebSite.InteractionModels;
using MoldovaHotelsCore.GlobalWebSite.Models;
using MoldovaHotelsCore.GlobalWebSite.Services.Interfaces;
using System.Net.Http;
using System.Net.Http.Formatting;
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

        public async Task<decimal> CalculatePriceAsync(decimal baseRoomPrice, int numberOfAdults,
            int numberOfChildren)
        {
            string uri = $"/api/bookings/price?baseRoomPrice={baseRoomPrice}&" +
                $"numberOfAdults={numberOfAdults}&numberOfChildren={numberOfChildren}";
            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);

            return await responseMessage.Content.ReadAsAsync<decimal>();
        }

        public async Task<Booking> MakeBookingAsync(CreateBookingInteractionModel booking)
        {
            HttpResponseMessage responseMessage = await httpClient.PostAsync(
                "/api/bookings", booking, new JsonMediaTypeFormatter(), null);
            responseMessage.EnsureSuccessStatusCode();

            return await responseMessage.Content.ReadAsAsync<Booking>();
        }
    }
}
