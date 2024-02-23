using System;
using System.Collections.Generic;

namespace ShopBO.Models
{
    public partial class Cosmetic
    {
        public string CosmeticId { get; set; } = null!;
        public string CosmeticName { get; set; } = null!;
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Quality { get; set; }
        public string? CategoryId { get; set; }
    }
}
