using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Models.Dao
{
    public class CustomerDao
    {
        ShopModel shopModel;
        public CustomerDao()
        {
            shopModel = new ShopModel();
        }
        //Lấy danh sách 
        public List<Customer> getList()
        {

            return shopModel.Customers.ToList();
        }
        //Lấy theo id
        public Customer getByID(string id)
        {
            Customer Customer = shopModel.Customers.Find(id);
            return Customer;
        }

        //Thêm mới
        public bool AddCustomer(Customer model)
        {
            Customer db = shopModel.Customers.Find(model.id);

            if (db != null)
            {
                return false;
            }
            shopModel.Customers.Add(model);
            shopModel.SaveChanges();

            return true;
        }
        //Sửa
        public bool Update(Customer model)
        {
            Customer dbEntry = shopModel.Customers.Find(model.id);

            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.id = model.id;
            dbEntry.name = model.name;
            dbEntry.address_ship = model.address_ship;
            dbEntry.phone = model.phone;
            dbEntry.identification = model.identification;
            dbEntry.email = model.email;
            dbEntry.age = model.age;
            dbEntry.sex = model.sex;
            dbEntry.account = model.account;
            


            shopModel.SaveChanges();

            return true;
        }
        //Xóa

        public bool Delete(string id)
        {
            Customer dbEntry = shopModel.Customers.Find(id);
            if (dbEntry == null)
            {
                return false;
            }
            shopModel.Customers.Remove(dbEntry);

            shopModel.SaveChanges();
            return true;
        }
    }
}