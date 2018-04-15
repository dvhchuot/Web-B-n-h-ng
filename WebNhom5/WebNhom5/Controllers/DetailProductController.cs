using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhom5.Models.Dao;
namespace WebNhom5.Controllers
{
    public class DetailProductController : Controller
    {
        // GET: DetailProduct
        public ActionResult Index()
        {
            
            return View();
        }
        
        public ActionResult ChiTiet(string id)
        {
            var model = new ProductDao().getByID(id);
            return View("Index",model);
        }



    }
}