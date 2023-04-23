using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE6.Inheritance.Models;

namespace EFCORE6.Inheritance.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
