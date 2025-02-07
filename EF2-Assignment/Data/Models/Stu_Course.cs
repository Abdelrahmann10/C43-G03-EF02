using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_Assignment.Data.Models
{
    internal class Stu_Course
    {
        [Key]
        public int stu_Id { get; set; }
        public int course_Id { get; set; }
        public int Grade { get; set; }
    }
}
