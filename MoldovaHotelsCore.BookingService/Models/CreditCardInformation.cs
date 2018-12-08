namespace MoldovaHotelsCore.BookingService.Models
{
    public class CreditCardInformation
    {
        public CardType CardType { get; set; }
        public string CardNumber { get; set; }
        public string SecurityCode { get; set; }

        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
