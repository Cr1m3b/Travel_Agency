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


        [Display(Name = "First Name")]
        //[Required(ErrorMessage = "The firstname is required.")]
        //[MinLength(2, ErrorMessage = "First name cannot be less than 2")]
        //[MaxLength(20, ErrorMessage = "First name cannot be greater than 20")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        //[Required(ErrorMessage = "The last name is required.")]
        //[MinLength(2, ErrorMessage = "Last name cannot be less than 2")]
        //[MaxLength(20, ErrorMessage = "Last name cannot be greater than 20")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        //[Required(ErrorMessage = "Contact phone is required.")]
        //[DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Contact Number")]
        //[RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Contact Number.")]
        public string ContactNumber { get; set; }

        [Display(Name = "Enter your country")]
        //[Required(ErrorMessage = "Country is required.")]
        //[MinLength(2, ErrorMessage = "Country name cannot be less than 2")]
        //[MaxLength(20, ErrorMessage = "Country name cannot be greater than 20")]
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
