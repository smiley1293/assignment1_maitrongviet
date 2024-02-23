using ShopBO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAO
{
    public class CosmeticDAO
    {
        private readonly CosmeticsShopManagementContext _db = null;
        private static CosmeticDAO instance = null;

        public static CosmeticDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CosmeticDAO();
                }
                return instance;
            }
        }

        public CosmeticDAO()
        {
            _db = new CosmeticsShopManagementContext();
        }

        public List<Cosmetic> getCosmetics()
        {
            return _db.Cosmetics.ToList();
        }

        //Lấy Id
        public Cosmetic GetCosmetic(string id)
        {
            return _db.Cosmetics.FirstOrDefault(eachCosmetic => eachCosmetic.CosmeticId.Equals(id));
        }

        //Add cosmetic
        public bool AddCosmetic(Cosmetic cosmetic)
        {
            bool result = false;
            try
            {
                _db.Add(cosmetic);
                _db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
               
                return result;
            }
            return result;
        }

        //Login
        public Account Login(string email, string pass)
        {
            Account user = _db.Accounts.FirstOrDefault(eachRowInAccountTable => eachRowInAccountTable.Email == email &&
                                                    eachRowInAccountTable.Password == pass);

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        //Get username
        

        //Update
        public bool UpdateCosmetic(Cosmetic cosmetic)
        {
            bool result = false;
            try
            {
                _db.Update(cosmetic);
                _db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }

        public bool DeleteCosmetic(Cosmetic cosmetic)
        {
            bool result = false;
            try
            {
                _db.Remove(cosmetic);
                _db.SaveChanges();
                result = true;
            }
            catch(Exception ex)
            {
                return result;
            }
            return result;
        }
        


    }
}
