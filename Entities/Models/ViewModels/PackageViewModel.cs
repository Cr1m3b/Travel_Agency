using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.ViewModels
{
    public class PackageViewModel
    {
        public List<Package> ActivePackages { get; set; }
        public List<Package> PackageOffer { get; set; }
        public List<Package> PopularPackages { get; set; }
        public List<Package> TopDestinationsPackages { get; set; }
        public List<Comment> TopComments { get; set; }
        public List<Comment> AllComments { get; set; }
    }
}
