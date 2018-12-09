using MoldovaHotelsCore.GlobalWebSite.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MoldovaHotelsCore.GlobalWebSite.ViewModels
{
    public class NewBookingViewModel
    {
        public string UserId { get; set; }

        public int RoomId { get; set; }

        [Display(Name = "CheckIn")]
        public DateTime CheckIn { get; set; }

        [Display(Name = "CheckOut")]
        public DateTime CheckOut { get; set; }

        [Display(Name = "FirstName")]
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "CardType")]
        public CardType CardType { get; set; }

        [Display(Name = "CardNumber")]
        [StringLength(16, MinimumLength = 16)]
        [Required]
        public string CardNumber { get; set; }

        [Display(Name = "SecurityCode")]
        [StringLength(3, MinimumLength = 3)]
        [Required]
        public string SecurityCode { get; set; }

        [Range(1, 12)]
        public int ExpiryMonth { get; set; }

        [Range(2016, 2500)]
        public int ExpiryYear { get; set; }

        [Display(Name = "EmailAddress")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "TelephoneNumber")]
        public string TelephoneNumber { get; set; }
    }
}
