using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class BrandDao
    {
        ShopModel shopModel;
        public BrandDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Brand> getList()
        {

            return shopModel.Brands.ToList();
        }
        //Lấy theo id
        public Brand getByID(string id)
        {
            Brand Brand = shopModel.Brands.Find(id);
            return Brand;
        }

        //Thêm mới
        public bool AddBrand(Brand model)
        {
            Brand db = shopModel.Brands.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.Brands.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Brand model)
        {
            Brand dbEntry = shopModel.Brands.Find(model.id);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.id = model.id;
            dbEntry.name = model.name;
            


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Brand dbEntry = shopModel.Brands.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Brands.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}