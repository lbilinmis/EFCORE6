using System;
using System.Collections.Generic;

namespace EFCORE6.DatabaseFirstByScaffold.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
