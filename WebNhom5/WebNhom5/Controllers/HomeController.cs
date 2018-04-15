using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhom5.Models.Dao;
namespace WebNhom5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int page=1,int pageSize=12)
        {

            ProductDao productDao = new ProductDao();
            
            return View(productDao.getListPaging(page, pageSize));
        }
        
    }
}