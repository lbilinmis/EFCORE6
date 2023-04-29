
using EFCORE6.Inheritance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.Inheritance.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [Precision(9,2)]
        public decimal Price { get; set; }

        [Precision(9, 2)]
        public decimal DiscountPrice { get; set; }
        public int Stock { get; set; }
        public string? Barcode { get; set; }
        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } // Navigation property

        public ProductDetail ProductDetail { get; set; } // Navigation property

    }
}
