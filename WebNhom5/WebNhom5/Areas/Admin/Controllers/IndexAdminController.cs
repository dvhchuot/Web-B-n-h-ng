using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhom5.Models.Dao;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Areas.Admin.Controllers
{
    public class IndexAdminController : Controller
    {
        // GET: Admin/Index
        public ActionResult Index()
        {
            
                ProductDao productDao = new ProductDao();

                return PartialView("_PartialTable", productDao.getListPaging(1, 10));
            
            
            
        }
        public ActionResult Combobox()
        {

            BrandDao brandDao = new BrandDao();
            ViewBag.Brand = brandDao.getList();
            StypeDao stypesDao = new StypeDao();
            ViewBag.Stype = stypesDao.getList();
            ColorDao colorDao = new ColorDao();
            ViewBag.Color = colorDao.getList();
            return PartialView("_PartialCombobox");

        }


    }
}