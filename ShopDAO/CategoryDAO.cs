using ShopBO.Models;

namespace ShopDAO
{
    public class CategoryDAO
    {
        private readonly CosmeticsShopManagementContext _db = null;
        private static CategoryDAO instance = null;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
        }

        public CategoryDAO()
        {
            _db = new CosmeticsShopManagementContext();
        }

        public List<CosmeticCategory> GetCategories()
        {
            return _db.CosmeticCategories.ToList();
        }
    }
}