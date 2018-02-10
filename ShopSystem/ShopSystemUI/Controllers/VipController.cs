using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopSystemBLL;
using ShopSystemEntity;
using ShopSystemTool;

namespace ShopSystemUI.Controllers
{
    public class VipController : BaseController
    {
        //
        // GET: /Vip/

        public ActionResult Index()
        {
            var vipLs=VipScoreBLL.Instance.GetVipScoreListByPage(1, 10, "", "");
            return View(vipLs);
        }

        public ActionResult AddVipData(string Id)
        {
            var vipEntity = new VipScore();
            if (!string.IsNullOrEmpty(Id))
            {
                vipEntity = VipScoreBLL.Instance.GetVipScroeModel(Guid.Parse(Id));
                ViewBag.ShowTitle = "VIP信息编辑";
            }
            else
            {
                //自动生成vip卡号
                var cardNumber = RandomNumber.Instance.GetRandom3();
                ViewBag.VipCode = cardNumber;
                ViewBag.ShowTitle = "VIP信息添加";
            }
            return View(vipEntity);
        }

        public JsonResult SaveVipData(VipScore model)
        {
            if (GetUserInfoEntity() == null)
            {
                Response.Status = "301 Moved Permanently";
                Response.StatusCode = 301;
                Response.AppendHeader("Location", "/Login");
            }
            else
            {
                if (model.Id != Guid.Empty)
                {
                    //得到vip信息
                    var vipmodle = VipScoreBLL.Instance.GetModel(model.Id);
                    if (vipmodle != null)
                    {
                        vipmodle.Score = model.Score;
                        vipmodle.VipName = model.VipName;
                        vipmodle.VipPhone = model.VipPhone;
                        vipmodle.VipSex = model.VipSex;
                        vipmodle.VipRemark = model.VipRemark;
                        vipmodle.UpdateBy = GetUserInfoEntity().Id;
                        vipmodle.UpdateDate = DateTime.Now;
                        if (VipScoreBLL.Instance.Update(vipmodle))
                        {
                            return Json(new { success = true, error = new { code = 202, message = "保存成功" } });
                        }
                        return Json(new { success = false, error = new { code = 301, message = "保存失败" } });
                    }
                }
                else
                {
                    model.CreateBy = GetUserInfoEntity().Id;
                    model.CreateDate = DateTime.Now;
                    model.UpdateBy = GetUserInfoEntity().Id;
                    model.UpdateDate = DateTime.Now;
                    model.Status = "ACTIVE";
                    VipScoreBLL.Instance.Add(model);
                }
                return Json(new { success = true, error = new { code = 202, message = "保存成功" } });
            }
            return Json(new { success = false, error = new { code = 301, message = "保存失败" } });
        }
    }
}
