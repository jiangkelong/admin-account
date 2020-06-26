using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminTET.Common
{
    /// <summary>
    /// 页面-用户登录验证
    /// </summary>
    public class PageAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //使[AllowAnonymous]生效
            bool flag = filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true) || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true);
            if (flag)
            {
                return;
            }
            var httpContext = filterContext.HttpContext;
            var request = httpContext.Request;
            ActionResult actionResult = null;
            if (httpContext.Session["UserID"] == null)
            {
                //若登录失效，则转发到登录失效提示页

                UrlHelper urlHelper = new UrlHelper(request.RequestContext);
                //利用Action 指定的操作名称、控制器名称和路由值生成操作方法的完全限定 URL。
                string returnUrl = urlHelper.Action("UnauthorizedError", "Home");
                actionResult = new RedirectResult(returnUrl);
            }
            filterContext.Result = actionResult;
        }
    }
}