using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
public sealed class LoginVerificaAttribute : ActionFilterAttribute
{
    /// <summary>
    /// 当标注了[LoginVerifica]的时候会执行
    /// </summary>
    /// <param name="filterContext">请求上下文</param>
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        if (filterContext.HttpContext.Session["Account"] == null)
        {
            //filterContext.Result = new RedirectToRouteResult("Default",
            //new System.Web.Routing.RouteValueDictionary(new { controller = "Home", action = "Login" })
            //);
            //登录后的跳转页面，默认为首页
            var returnUrl = "";
            //if (!filterContext.HttpContext.Request.RawUrl.IsNullOrEmpty())
            //{
            //    returnUrl = "?returnUrl=" + filterContext.HttpContext.Request.RawUrl;
            //}
            filterContext.HttpContext.Response.Write("<script>window.top.location='/Login/Index" + returnUrl + "';</script>");
            filterContext.Result = new EmptyResult();
        }
    }
}