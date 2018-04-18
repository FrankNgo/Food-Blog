using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FoodBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}

