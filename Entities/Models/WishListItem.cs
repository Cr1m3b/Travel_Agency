using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class WishListItem
    {
        public Package Package { get; set; }
        public int Quantity { get; set; }
    }
}
