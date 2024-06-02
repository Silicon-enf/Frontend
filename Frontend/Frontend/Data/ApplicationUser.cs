using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Biography { get; set; }
        public string? ProfileImage { get; set; } = "avatar.jpg";

        public int? AdressId { get; set; }
        public AdressEntity? Adress { get; set; }
    }

    public class AdressEntity
    {
        [Key]
        public int Id { get; set; }
        public string AdressLine_1 { get; set; } = null!;
        public string? AdressLine_2 { get; set; }
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;

    }
}
