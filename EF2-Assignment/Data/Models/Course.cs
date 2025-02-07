using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_Assignment.Data.Models
{
    internal class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // (1, 1)
        public int Id { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
