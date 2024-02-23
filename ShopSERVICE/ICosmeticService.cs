using ShopBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSERVICE
{
    public interface ICosmeticService
    {
        public List<Cosmetic> GetCosmetics();
        public bool AddCosmetic(Cosmetic cosmetic);
        public Account Login(string email, string pass);
        public List<CosmeticCategory> GetCategories();
        public Cosmetic GetCosmetic(string id);
        public bool UpdateCosmetic(Cosmetic cosmetic);
        public bool DeleteCosmetic(Cosmetic cosmetic);
        

    }
}
