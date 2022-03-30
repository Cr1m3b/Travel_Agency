using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entities.Models
{
    public class Item
    {
        
        public Package Package { get; set; }
        public int Quantity { get; set; }
    }
}
