using Entities.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Photo
    {
        public Photo()
        {
           Packages=new HashSet<Package>();
        }
        public int PhotoId { get; set; }
        [Display(Name = "Photo URL")]
        public string Url { get; set; }
        public Destinations Destinations { get; set; }

        //Navigation Properties

        public  ICollection<Package> Packages { get; set; }
    }
}
