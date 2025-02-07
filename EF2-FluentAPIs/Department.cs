using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_FluentAPIs
{
    public class Department
    {
        public int DepId { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
    }
}
