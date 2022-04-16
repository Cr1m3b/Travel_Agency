using Entities.Models;
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
        public ApplicationUser()
        {
            Bookings = new HashSet<Booking>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ReplyComment> ReplyComments { get; set; }
        public DateTime? Birthday { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public Image UserImage { get; set; }
        


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

    }
}
