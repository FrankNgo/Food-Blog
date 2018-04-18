using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodBlog.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public int locaitonId { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string location { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }

    }
}
