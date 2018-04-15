using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhom5.Models.Dao;
using WebNhom5.Models.Entitis;
namespace WebNhom5.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {


            ProductDao productDao = new ProductDao();

            return View(productDao.getListPaging(1, 12));
        }

        
        public ActionResult Search(string search)
        {
            ShopModel shopModel = new ShopModel();
            var model = shopModel.Products.Where(x => x.name.Contains(search)).OrderByDescending(x => x.id).ToPagedList(1, 9);
            return View("Index",model);
        }
        
        public ActionResult Brand(string id)
        {
            ShopModel shopModel = new ShopModel();
            var model = shopModel.Products.Where(x => x.Brand.name.Contains(id)).OrderByDescending(x => x.id).ToPagedList(1, 9);
            return View("Index", model);
        }
        
        public ActionResult Color(string id)
        {
            ShopModel shopModel = new ShopModel();
            var model = shopModel.Products.Where(x => x.Color.name.Contains(id)).OrderByDescending(x => x.id).ToPagedList(1, 9);
            return View("Index", model);
        }
        
        public ActionResult Stype(string id)
        {
            ShopModel shopModel = new ShopModel();
            var model = shopModel.Products.Where(x => x.stype.name.Contains(id)).OrderByDescending(x => x.id).ToPagedList(1, 9);
            return View("Index", model);
        }
    }
}