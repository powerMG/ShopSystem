using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ShopSystemBLL;
using ShopSystemEntity;

namespace ShopSystemUI
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUserInfo(UserInfo model)
        {
            //StringBuilder strWhere = new StringBuilder();
            //if (!string.IsNullOrEmpty(model.UserName) && !string.IsNullOrEmpty(model.Password))
            //{
            //    strWhere.Append(string.Format("UserName='{0}' and Password='{1}'", model.UserName, model.Password));
            //}
            //var userModel = UserInfoBLL.Instance.GetModel(strWhere.ToString());

            var userModel = UserInfoBLL.Instance.GetUserInfoData(model);
            var success = false;
            var errorText = "用户名，密码输入有误。";
            if (userModel != null)
            {
                Session["Account"] = userModel;
                success = true;
                errorText = "";
            }
            return Json(new { Success = success, ErrorText = errorText });
        }
    }
}
