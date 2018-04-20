using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebNhom5.Models.Entitis
{
    public class AdminCreditAttribute : AuthorizeAttribute
    {
        public string RoleID { set; get; }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var session = (UserLogin)HttpContext.Current.Session[CommonConstants.LoginSession];
            if (session == null)
            {
                return false;
            }

            List<string> privilegeLevels = this.GetCredentialByLoggedInUser(session.account); // Call another method to get rights of the user from DB

            if (privilegeLevels.Contains(this.RoleID) || session.groupId == Group.admin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Areas/Admin/Views/Shared/404.cshtml"
            };
        }
        private List<string> GetCredentialByLoggedInUser(string userName)
        {
            var credentials = (List<string>)HttpContext.Current.Session[CommonConstants.CreditSession];
            return credentials;
        }
    }
}