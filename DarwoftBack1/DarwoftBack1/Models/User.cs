using System;
using System.Collections.Generic;

#nullable disable

namespace DarwoftBack1.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdTypeUser { get; set; }

        public virtual Client Client { get; set; }
    }
}
