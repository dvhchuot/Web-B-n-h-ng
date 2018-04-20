using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class UserLoginsDao
    {
        ShopModel shopModel;
        public UserLoginsDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<UserLogin> getList()
        {

            return shopModel.UserLogins.ToList();
        }
        //Lấy theo id
        public UserLogin getByID(string id)
        {
            UserLogin User = shopModel.UserLogins.Find(id);
            return User;
        }
        public int Login(string userName, string passWord, bool isLoginAdmin = false)
        {
            var result = shopModel.UserLogins.SingleOrDefault(x => x.account == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (isLoginAdmin == true)
                {
                    if (result.groupId == Group.admin|| result.groupId == Group.mod)
                    {
                        
                        if (result.password == passWord)
                                return 1;
                         else
                                return -2;
                        
                    }
                    else
                    {
                        return -3;
                    }
                }
                else
                {
                    
                        if (result.password == passWord)
                            return 1;
                        else
                           return -2;
                    
                }
            }
        }

        public List<string> GetListCredential(string userName)
        {
            var user = shopModel.UserLogins.Single(x => x.account == userName);
            var data = (from a in shopModel.Credits
                        join b in shopModel.GroupUsers on a.Id_group equals b.Id
                        join c in shopModel.Roles on a.Id_Role equals c.Id
                        where b.Id == user.groupId
                        select new
                        {
                            Id_Role = a.Id_Role,
                            Id_group = a.Id_group
                        }).AsEnumerable().Select(x => new Credit()
                        {
                            Id_Role = x.Id_Role,
                            Id_group = x.Id_group
                        });
            return data.Select(x => x.Id_Role).ToList();

        }
        //Thêm mới
        public bool AddUser(UserLogin model)
        {
            UserLogin db = shopModel.UserLogins.Find(model.account);

            if (db != null)
            {
                return false;
            }
            shopModel.UserLogins.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(UserLogin model)
        {
            UserLogin dbEntry = shopModel.UserLogins.Find(model.account);

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
            UserLogin dbEntry = shopModel.UserLogins.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.UserLogins.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}