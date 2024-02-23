using System;
using System.Collections.Generic;

namespace ShopBO.Models
{
    public partial class Account
    {
        public string Email { get; set; } = null!;
        public string? Username { get; set; }
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
    }
}
