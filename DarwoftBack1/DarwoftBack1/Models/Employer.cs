using System;
using System.Collections.Generic;

#nullable disable

namespace DarwoftBack1.Models
{
    public partial class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdBoss { get; set; }
    }
}
