using Microsoft.AspNetCore.Identity;

namespace AS_Assignment.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? CreditCardNo { get; set; }

        public string? BillingAddress { get; set; }

        public string? ShippingAddress { get; set; }

        public DateTime? LastPasswordChangeDate { get; set; }

        public byte[]? Image { get; set; }
    }
}
