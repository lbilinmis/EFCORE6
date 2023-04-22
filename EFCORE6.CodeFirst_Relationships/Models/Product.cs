﻿
using EFCORE6.CodeFirst_Relationships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE6.CodeFirst_Relationships.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Barcode { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } // Navigation property

        public ProductDetail ProductDetail { get; set; }

    }
}
