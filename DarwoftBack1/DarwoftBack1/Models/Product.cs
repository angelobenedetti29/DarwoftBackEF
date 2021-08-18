using System;
using System.Collections.Generic;

#nullable disable

namespace DarwoftBack1.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int MinimumStock { get; set; }
    }
}
