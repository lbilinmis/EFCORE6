using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.Inheritance.Models
{
    public class PersonEmployee 
    {
        public int Id { get; set; }
        [Precision(18, 2)]
        public NewPerson Person { get; set; }
        public decimal  Salary{ get; set; }
    }
}
