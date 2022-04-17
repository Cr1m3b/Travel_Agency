using Entities.IdentityUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.ViewModels
{
    public class DashboardViewModel
    {
        public List<ApplicationUser> Users { get; set; }

        public decimal Earnings { get; set; }
        public List<Booking> TodayBookings { get; set; }
        public List<Booking> RecentBookings { get; set; }
        public List<Package> AdminPackages { get; set; }

    }
}
