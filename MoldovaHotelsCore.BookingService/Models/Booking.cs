﻿using System;

namespace MoldovaHotelsCore.BookingService.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int RoomId { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public decimal TotalPrice { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public CreditCardInformation CreditCardInformation { get; set; }

        public string EmailAddress { get; set; }

        public string TelephoneNumber { get; set; }
    }
}
