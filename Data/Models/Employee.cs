using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2.Data.Models
{
    // We have 4 ways to map a class
    // 1- By Convention
    // 2- Data Annotation (Set of Attributes)
    // 3- Fluent APIs (Set of Methods)
    // 4- 
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // (1, 1)
        public int Code { get; set; }

        [Column(TypeName = "varchar")]
        //[StringLength(50,MinimumLength = 10)]
        [MinLength(50)]
        [Length(10,50)] //Range
        public string? Name { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public double Salary { get; set; }

        [Range(22,60)]
        [AllowedValues(20,21,22,23)]
        [DeniedValues(10,15)]
        public int? Age { get; set; }

        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        public int PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
