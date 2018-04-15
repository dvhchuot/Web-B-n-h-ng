using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class SaleDao
    {
        ShopModel shopModel;
        public SaleDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Sale> getList()
        {

            return shopModel.Sales.ToList();
        }
        //Lấy theo id
        public Sale getByID(string id)
        {
            Sale Sale = shopModel.Sales.Find(id);
            return Sale;
        }

        //Thêm mới
        public bool AddSale(Sale model)
        {
            Sale db = shopModel.Sales.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.Sales.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Sale model)
        {
            Sale dbEntry = shopModel.Sales.Find(model.id);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.id = model.id;
            dbEntry.id_Products = model.id_Products;
            dbEntry.info = model.info;
        


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Sale dbEntry = shopModel.Sales.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Sales.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}