using System;
using System.Collections.Generic;

namespace ShopBO.Models
{
    public partial class CosmeticCategory
    {
        public string CategoryId { get; set; } = null!;
        public string? CategoryName { get; set; }
        public string Description { get; set; } = null!;
    }
}
