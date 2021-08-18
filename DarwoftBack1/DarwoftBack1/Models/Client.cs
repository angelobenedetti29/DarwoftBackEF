using System;
using System.Collections.Generic;

#nullable disable

namespace DarwoftBack1.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Amount { get; set; }

        public virtual User IdNavigation { get; set; }
    }
}
