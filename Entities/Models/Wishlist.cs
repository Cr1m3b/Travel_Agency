using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Wishlist
    {
        public Wishlist()
        {
            Packages = new List<Package>();
        }
        public int WishlistId { get; set; }
        List<Package> Packages { get; set; }

    }
}
