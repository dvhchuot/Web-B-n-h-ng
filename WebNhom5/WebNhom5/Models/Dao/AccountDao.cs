using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class AccountDao
    {
        ShopModel shopModel;
        public AccountDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Account> getList()
        {

            return shopModel.Accounts.ToList();
        }
        //Lấy theo id
        public Account getByID(string id)
        {
            Account Account = shopModel.Accounts.Find(id);
            return Account;
        }

        //Thêm mới
        public bool AddAccount(Account model)
        {
            Account db = shopModel.Accounts.Find(model.name);

            if (db != null)
            {
                return false;
            }
            shopModel.Accounts.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Account model)
        {
            Account dbEntry = shopModel.Accounts.Find(model.name);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.name = model.name;
            dbEntry.password = model.password;
            


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Account dbEntry = shopModel.Accounts.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Accounts.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}