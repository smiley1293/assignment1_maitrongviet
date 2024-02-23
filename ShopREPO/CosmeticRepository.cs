using ShopBO.Models;
using ShopDAO;

namespace ShopREPO
{
    public class CosmeticRepository : ICosmeticRepository
    {
        public bool AddCosmetic(Cosmetic cosmetic) => CosmeticDAO.Instance.AddCosmetic(cosmetic);

        public bool DeleteCosmetic(Cosmetic cosmetic) => CosmeticDAO.Instance.DeleteCosmetic(cosmetic);

        public List<CosmeticCategory> GetCategories() => CategoryDAO.Instance.GetCategories();

        public Cosmetic GetCosmetic(string id) => CosmeticDAO.Instance.GetCosmetic(id);

        public List<Cosmetic> GetCosmetics() => CosmeticDAO.Instance.getCosmetics();


        

        public Account Login(string email, string pass) => CosmeticDAO.Instance.Login(email, pass);

        public bool UpdateCosmetic(Cosmetic cosmetic) => CosmeticDAO.Instance.UpdateCosmetic(cosmetic);
        
    }
}