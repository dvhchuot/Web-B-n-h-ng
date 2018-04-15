using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhom5.Models.Dao;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Controllers
{
    public class LayOutController : Controller
    {
        // GET: LayOut
        public ActionResult Index()
        {

            StypeDao stypesDao = new StypeDao();
            ViewBag.stypesDao = stypesDao.getList();
            return PartialView("_PartialMenu");


        }
        public ActionResult SideBar()
        {
            BrandDao brandDao = new BrandDao();
            ViewBag.brandDao = brandDao.getList();
            StypeDao stypesDao = new StypeDao();
            ViewBag.stypesDao = stypesDao.getList();
            ColorDao colorDao = new ColorDao();
            ViewBag.colorDao = colorDao.getList();
            return PartialView("_PartialSideBar");
        }
        public ActionResult Cart()
        {

            var cart = Session[CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            
            return PartialView("_PartialCart", list);


        }
    }
}