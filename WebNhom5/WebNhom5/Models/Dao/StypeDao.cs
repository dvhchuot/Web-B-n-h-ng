using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class StypeDao
    {
        ShopModel shopModel;
        public StypeDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<stype> getList()
        {

            return shopModel.stypes.ToList();
        }
        //Lấy theo id
        public stype getByID(string id)
        {
            stype stype = shopModel.stypes.Find(id);
            return stype;
        }

        //Thêm mới
        public bool Addstype(stype model)
        {
            stype db = shopModel.stypes.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.stypes.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(stype model)
        {
            stype dbEntry = shopModel.stypes.Find(model.id);

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
            stype dbEntry = shopModel.stypes.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.stypes.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}