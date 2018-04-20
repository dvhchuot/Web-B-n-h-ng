using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNhom5.Models.Dao;
using WebNhom5.Models.Entitis;

namespace WebNhom5.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            if (Session[CommonConstants.LoginSession] != null) return RedirectToAction("Index", "ProductsAdmin");
            return View();
        }
        [HttpPost]
        public ActionResult LoginActionAdmin(string username, string pass)
        {
            //var check = new UsersDao().getByID(username);
            //if (check==null) return RedirectToAction("Index", "Admin/LoginAdmin");
            //else
            //{
            //    if(check.password==pass)
            //    {
            //        Session[CommonConstants.LoginSession] = check.name;
            //        return RedirectToAction("Index", "Admin/ProductsAdmin");
            //    }
            //    else return RedirectToAction("Index");
            //}
            if (ModelState.IsValid)
            {
                var dao = new UserLoginsDao();
                var result = dao.Login(username, pass, true);
                if (result == 1)
                {
                    var user = dao.getByID(username);
                    

                    var listCredentials = dao.GetListCredential(username);

                    Session.Add(CommonConstants.CreditSession, listCredentials);
                    Session[CommonConstants.NameSession] = user.name;
                    Session[CommonConstants.LoginSession] = user;
                    return RedirectToAction("Index", "ProductsAdmin");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khoá.");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng.");
                }
                else if (result == -3)
                {
                    ModelState.AddModelError("", "Tài khoản của bạn không có quyền đăng nhập.");
                }
                else
                {
                    ModelState.AddModelError("", "đăng nhập không đúng.");
                }
            }
            return View("Index");


        }
        
        public ActionResult LogoutAdmin()
        {
            Session[CommonConstants.NameSession] = null;
            Session[CommonConstants.LoginSession] = null;
            return RedirectToAction("Index");
        }
    }
}