using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Entities
{
    internal class Operations:BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
