using System;
using System.Collections.Generic;

namespace DBFirstAPI.Models
{
    public partial class Register
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ConfPassword { get; set; }
        public string? UserType { get; set; }
    }
}
