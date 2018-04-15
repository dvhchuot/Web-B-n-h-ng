using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class BillDao
    {
        ShopModel shopModel;
        public BillDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Bill> getList()
        {

            return shopModel.Bills.ToList();
        }
        //Lấy theo id
        public Bill getByID(string id)
        {
            Bill Bill = shopModel.Bills.Find(id);
            return Bill;
        }

        //Thêm mới
        public int AddBill(Bill model)
        {
            Bill db = shopModel.Bills.Find(model.id);

            if (db != null)
            {
                return -1;
            }
            shopModel.Bills.Add(model);
            shopModel.SaveChanges();

            return model.id;
        }
        //Sửa
        public bool Update(Bill model)
        {
            Bill dbEntry = shopModel.Bills.Find(model.id);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.id = model.id;
            dbEntry.name = model.name;
            dbEntry.date = model.date;
            dbEntry.address = model.address;
            dbEntry.phone = model.phone;
            dbEntry.email = model.email;
            


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Bill dbEntry = shopModel.Bills.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Bills.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}