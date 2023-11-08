using System;
using System.Collections.Generic;

namespace DBFirstAPI.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
    }
}
