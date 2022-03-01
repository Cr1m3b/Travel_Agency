using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IdentityUsers
{
    public class ApplicationUser : IdentityUser
    {


        [Display(Name = "Enter your first name :")]
        [Required(ErrorMessage = "The firstname is required.")]
        [Range(2, 20, ErrorMessage = "The firstname must be between 2 and 20 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Enter your last name :")]
        [Required(ErrorMessage = "The laststname is required.")]
        [Range(2, 20, ErrorMessage = "The lastname must be between 2 and 20 characters")]
        public string LastName { get; set; }

        [Display(Name = "Enter your contact phone number:")]
        [Required(ErrorMessage = "Contact phone is required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Contact Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Contact Number.")]
        public string ContactNumber { get; set; }

        [Display(Name = "Enter your country:")]
        [Required(ErrorMessage = "Country is required.")]
        [Range(3, 12, ErrorMessage = "The name of the country must be between 3 and 12 characters")]
        public string Country { get; set; }





        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
