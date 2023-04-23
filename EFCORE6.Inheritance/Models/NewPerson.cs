using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.Inheritance.Models
{
    [Owned] // bu şeklide tanımlandığında context de bu  tbl tanımlanmaz
    public class NewPerson
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
    }
}
