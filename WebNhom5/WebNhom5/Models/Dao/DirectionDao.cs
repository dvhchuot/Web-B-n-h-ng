using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class DirectionDao
    {
        ShopModel shopModel;
        public DirectionDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Direction> getList()
        {

            return shopModel.Directions.ToList();
        }
        //Lấy theo id
        public Direction getByID(string id)
        {
            Direction Direction = shopModel.Directions.Find(id);
            return Direction;
        }

        //Thêm mới
        public bool AddDirection(Direction model)
        {
            Direction db = shopModel.Directions.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.Directions.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Direction model)
        {
            Direction dbEntry = shopModel.Directions.Find(model.id);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.id = model.id;
            dbEntry.name = model.name;
            dbEntry.address = model.address;
            dbEntry.phone = model.phone;
            dbEntry.identification = model.identification;
            dbEntry.email = model.email;
            dbEntry.account = model.account;
            


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Direction dbEntry = shopModel.Directions.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Directions.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}