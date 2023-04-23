
using EFCORE6.Inheritance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.Inheritance.Models
{
    public class NewProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //[Precision(18, 2)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Barcode { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } // Navigation property

        public NewProductDetail NewProductDetail { get; set; } // Navigation property

    }
}
