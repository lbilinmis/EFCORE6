using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.Inheritance.Models
{
    public class PersonManager 
    {
        public int Id { get; set; }
        public NewPerson Person { get; set; }

        public int Grade { get; set; }
    }
}
