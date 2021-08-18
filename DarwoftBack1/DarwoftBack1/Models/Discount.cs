using System;
using System.Collections.Generic;

#nullable disable

namespace DarwoftBack1.Models
{
    public partial class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount1 { get; set; }
        public DateTime? Since { get; set; }
        public DateTime? Until { get; set; }
    }
}
