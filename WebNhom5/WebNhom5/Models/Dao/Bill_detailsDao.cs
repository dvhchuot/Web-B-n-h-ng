using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class Bill_DetailsDao
    {
        ShopModel shopModel;
        public Bill_DetailsDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Bill_Details> getList()
        {

            return shopModel.Bill_Details.ToList();
        }
        //Lấy theo id
        public Bill_Details getByID(string id)
        {
            Bill_Details Bill_Details = shopModel.Bill_Details.Find(id);
            return Bill_Details;
        }

        //Thêm mới
        public bool AddBill_Details(Bill_Details model)
        {
            Bill_Details db = shopModel.Bill_Details.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.Bill_Details.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Bill_Details model)
        {
            Bill_Details dbEntry = shopModel.Bill_Details.Find(model.id);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.id = model.id;
            dbEntry.id_Product = model.id_Product;
            dbEntry.id_bill = model.id_bill;
            dbEntry.total_price = model.total_price;
            dbEntry.quantity = model.quantity;
            


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Bill_Details dbEntry = shopModel.Bill_Details.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Bill_Details.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}