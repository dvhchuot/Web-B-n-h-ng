using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhom5.Models.Entitis;
using WebNhom5.Models.Dao;
namespace WebNhom5.Areas.Admin.Controllers
{
    public class ProductsAdminController : Controller
    {
        // GET: Admin/ProductsAdmin
        public ActionResult index(int page=1, int pageSize=10)
        {
            ProductDao productDao = new ProductDao();

            return View( productDao.getListPaging(page, pageSize));
            
        }
        public ActionResult AddProducts()
        {
            return View();

        }
        public ActionResult EditProducts(string id)
        {
            BrandDao brandDao = new BrandDao();
            ViewBag.Brand = brandDao.getList();
            StypeDao stypesDao = new StypeDao();
            ViewBag.Stype = stypesDao.getList();
            ColorDao colorDao = new ColorDao();
            ViewBag.Color = colorDao.getList();
            var model = new ProductDao().getByID(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult AddProducts(Product sp)
        {
            try
            {
                // TODO: Add update logic here
                if (new ProductDao().AddProduct(sp))
                {

                    return RedirectToAction("AddProducts");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult EditProducts(Product sp)
        {
            try
            {
                // TODO: Add update logic here
                if (new ProductDao().Update(sp))
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult DeleteProducts(string id)
        {
            var model = new ProductDao().getByID(id);
            BrandDao brandDao = new BrandDao();
            ViewBag.Brand = brandDao.getList();
            StypeDao stypesDao = new StypeDao();
            ViewBag.Stype = stypesDao.getList();
            ColorDao colorDao = new ColorDao();
            ViewBag.Color = colorDao.getList();


            return View("EditProducts", model);

        }

        //
        // POST: /Admin/DanhMucAd/Delete/5

        [HttpPost]
        public ActionResult DeleteProducts(Product model)
        {
            try
            {
                if (new ProductDao().Delete(model.id))
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

    }
}