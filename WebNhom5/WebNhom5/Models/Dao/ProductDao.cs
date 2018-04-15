using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;
using PagedList.Mvc;
using PagedList;

namespace WebNhom5.Models.Dao
{
    public class ProductDao
    {
        ShopModel shopModel;
        public ProductDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Product> getList()
        {

            return shopModel.Products.ToList();
        }
        //Lấy theo id
        public IEnumerable<Product> getListPaging(int page, int pageSize)
        {
            return shopModel.Products.OrderByDescending(x => x.id).ToPagedList(page, pageSize);
        }
            
        public Product getByID(string id)
        {
            Product Product = shopModel.Products.Find(id);
            return Product;
        }

        //Thêm mới
        public bool AddProduct(Product model)
        {
            Product db = shopModel.Products.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.Products.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Product model)
        {
            Product dbEntry = shopModel.Products.Find(model.id);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.id = model.id;
            dbEntry.name = model.name;
            dbEntry.info = model.info;
            dbEntry.id_stype = model.id_stype;
            dbEntry.id_color = model.id_color;
            dbEntry.id_brand = model.id_brand;
            dbEntry.image = model.image;
            dbEntry.new_price = model.new_price;
            dbEntry.ole_price = model.ole_price;
            dbEntry.date_make = model.date_make;


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Product dbEntry = shopModel.Products.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Products.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}