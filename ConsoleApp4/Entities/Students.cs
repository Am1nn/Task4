using ConsoleApp4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Entities
{
    internal class Students:BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int SchoolNumber { get; set; }
        public Gender Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirtDay { get; set; }
        public ICollection<StudentBooks>? StudentBooks { get; set; }
    }
}
