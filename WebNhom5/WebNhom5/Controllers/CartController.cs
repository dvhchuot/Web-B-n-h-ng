using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebNhom5.Models.Dao;
using WebNhom5.Models.Entitis;
namespace WebNhom5.Controllers
{
    public class CartController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            var cart = Session[CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        public ActionResult AddItem(string id, int quantity)
        {

            var products = new ProductDao().getByID(id);
            var cart = Session[CommonConstants.CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.product.id == id))
                {

                    foreach (var item in list)
                    {
                        if (item.product.id == id)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    //tạo mới đối tượng cart item
                    var item = new CartItem();
                    item.product = products;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                //Gán vào session
                Session[CommonConstants.CartSession] = list;
            }
            else
            {
                //tạo mới đối tượng cart item
                var item = new CartItem();
                item.product = products;
                item.Quantity = quantity;
                var list = new List<CartItem>();
                list.Add(item);
                //Gán vào session
                Session[CommonConstants.CartSession] = list;
            }
            return RedirectToAction("Index");
        }
        public JsonResult DeleteAll()
        {
            Session[CommonConstants.CartSession] = null;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult Delete(string id)
        {
            var sessionCart = (List<CartItem>)Session[CommonConstants.CartSession];
            sessionCart.RemoveAll(x => x.product.id==id);
            Session[CommonConstants.CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }
        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var sessionCart = (List<CartItem>)Session[CommonConstants.CartSession];

            foreach (var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.product.id == item.product.id);
                if (jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;
                }
            }
            Session[CommonConstants.CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }
        
        
        public ActionResult Payment()
        {
            var cart = Session[CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        [HttpPost]
        public ActionResult Payment(string shipName, string mobile, string address, string email)
        {
            var order = new Bill();
            order.date = DateTime.Now;
            order.address = address;
            order.phone = mobile;
            order.name = shipName;
            order.email = email;

            try
            {
                var id = new BillDao().AddBill(order);
                var cart = (List<CartItem>)Session[CommonConstants.CartSession];
                var detailDao = new Bill_DetailsDao();
                double total = 0;
                foreach (var item in cart)
                {
                    var orderDetail = new Bill_Details();
                    orderDetail.id_Product = item.product.id;
                    orderDetail.id_bill = id;
                    orderDetail.total_price = item.product.new_price;
                    orderDetail.quantity = item.Quantity;
                    detailDao.AddBill_Details(orderDetail);

                    total += (item.product.new_price.GetValueOrDefault(0) * item.Quantity);
                }
                Session[CommonConstants.CartSession] = null;

            }
            catch (Exception ex)
            {
                //ghi log
                return Redirect("/Payment");
            }
            return Redirect("/Success");
        }

        public ActionResult Success()
        {
            return View();
        }

    }
}