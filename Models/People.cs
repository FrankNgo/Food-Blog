using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodBlog.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int personId { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int  experienceId { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
