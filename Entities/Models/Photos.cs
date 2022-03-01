using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Photos
    {
        public int PhotoId { get; set; }
        [Display(Name = "Photo URL")]
        public string Url { get; set; }

        //Navigation Properties
        public  Package Package { get; set; }
    }
}
