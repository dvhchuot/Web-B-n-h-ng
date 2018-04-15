using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class ColorDao
    {
        ShopModel shopModel;
        public ColorDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Color> getList()
        {

            return shopModel.Colors.ToList();
        }
        //Lấy theo id
        public Color getByID(string id)
        {
            Color Color = shopModel.Colors.Find(id);
            return Color;
        }

        //Thêm mới
        public bool AddColor(Color model)
        {
            Color db = shopModel.Colors.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.Colors.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Color model)
        {
            Color dbEntry = shopModel.Colors.Find(model.id);

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
            Color dbEntry = shopModel.Colors.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Colors.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}