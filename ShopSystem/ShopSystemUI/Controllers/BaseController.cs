using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopSystemEntity;

namespace ShopSystemUI.Controllers
{
    public class BaseController : Controller
    {
        public UserInfo GetUserInfoEntity()
        {
            return Session["Account"] as UserInfo;
        }
    }
}
