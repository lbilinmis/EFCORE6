using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.Inheritance.Models
{
    public class NewProductDetail
    {
        public int Id { get; set; }
        public int? Width { get; set; }
        public int? Weightth { get; set; }
        public int? Height { get; set; }
        public string? Color { get; set; }

        public NewProduct NewProduct { get; set; }

    }
}
