﻿using MoldovaHotelsCore.BookingService.Engines.Interfaces;
using MoldovaHotelsCore.BookingService.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoldovaHotelsCore.BookingService.Engines
{
    public class BookingEngine : IBookingEngine
    {
        public decimal CalculateRoomPrice(int roomId, int numberOfAdults, int numberOfChildren)
        {
            return 126.45m;
        }

        public decimal CalculateRoomPrice(decimal baseRoomPrice, int numberOfAdults, int numberOfChildren)
        {
            return baseRoomPrice * numberOfAdults * numberOfChildren;
        }

        public Task CancelBooking(string userId, int bookingId)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetBookingRowVersionFromApi(int localBookingId)
        {
            return Task.FromResult(new byte[] { 1, 2, 3 });
        }

        public List<BookingForUser> GetBookingsForUser(string userId, string language)
        {
            return new List<BookingForUser>
            {
                new BookingForUser()
            };
        }

        public Task<Booking> MakeBookingAsync(string userId, Booking booking, CreditCardInformation creditCardInformation)
        {
            var createdBooking = new Booking
            {
                BookingId = 54535,
                CheckIn = booking.CheckIn,
                CheckOut = booking.CheckOut,
                EmailAddress = booking.EmailAddress,
                FirstName = booking.FirstName,
                LastName = booking.LastName,
                RoomId = booking.RoomId,
                TelephoneNumber = booking.TelephoneNumber,
                TotalPrice = booking.TotalPrice
            };

            return Task.FromResult(createdBooking);
        }

        public Task UpdateBooking(EditBookingModel editBookingModel)
        {
            throw new NotImplementedException();
        }
    }
}
