using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebNhom5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Add Cart",
              url: "Add-product",
              defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
              namespaces: new[] { "WebNhom5.Controllers" });
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Home",
              url: "Home",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "WebNhom5.Controllers" });
            routes.MapRoute(
           name: "Payment",
           url: "Payment",
           defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional },
           namespaces: new[] { "WebNhom5.Controllers" });
            routes.MapRoute(
           name: "Success",
           url: "Success",
           defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional },
           namespaces: new[] { "WebNhom5.Controllers" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
           
        }
    }
}
