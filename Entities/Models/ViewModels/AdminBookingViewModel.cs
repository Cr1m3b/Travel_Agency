using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.ViewModels
{
    public class AdminBookingViewModel
    {
        public List<Booking> AdminBookings { get; set; }
        public List<Package> AdminPackages { get; set; }

    }
}
