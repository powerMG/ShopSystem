using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using ShopSystemBLL;
using ShopSystemEntity;

namespace ShopSystemUI.Controllers
{
    [LoginVerifica]
    public class StockController : BaseController
    {
        private readonly string fileName = "StockImg";
        //库存信息管理
        public ActionResult Index(int pageIndex = 1, int pagesize = 10)
        {
            var stockLs = StockInfoBLL.Instance.GetStockListByPage(pageIndex, pagesize, string.Format("Status='{0}'", "ACTIVE"), "");
            return View(stockLs);
        }

        public ActionResult AddStock(string stockId)
        {
            var stockEntity = new StockInfo();
            if (!string.IsNullOrEmpty(stockId))
            {
                stockEntity = StockInfoBLL.Instance.GetStockInfoModel(Guid.Parse(stockId));
                ViewBag.ShowTitle = "库存信息编辑";
            }
            else
            {
                ViewBag.ShowTitle = "库存信息添加";
            }
            return View(stockEntity);
        }
        //上传商品图片
        public JsonResult UpLoadeImg(string id, string name, string type, string lastModifiedDate, int size)
        {
            string filePathName = string.Empty;
            string filePathUrl = string.Empty;
            string urlPath = String.Format("/UploadFile/{0}", fileName);
            //string localPath = Path.Combine(HttpRuntime.AppDomainAppPath, "Upload");
            if (Request.Files.Count == 0)
            {
                return Json(new { success = false, error = new { code = 102, message = "保存失败" }, fileUrl = "error" });
            }
            try
            {
                if (Directory.Exists(Server.MapPath(urlPath)) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(Server.MapPath(urlPath));
                }
                var httpPostedFileBase = Request.Files[0];
                if (httpPostedFileBase != null)
                {
                    Guid imgId = Guid.NewGuid();
                    filePathName = httpPostedFileBase.FileName;
                    var newfileName = string.Format("{0}{1}", imgId, filePathName.Substring(filePathName.LastIndexOf(".", StringComparison.Ordinal)));
                    httpPostedFileBase.SaveAs(Server.MapPath(String.Format("{0}/{1}", urlPath, newfileName)));
                    filePathUrl = String.Format("{0}/{1}", urlPath, newfileName);//自行处理保存
                }
            }
            catch (Exception)
            {
                return Json(new { success = false, error = new { code = 103, message = "保存失败" }, fileUrl = "error" });
            }
            return Json(new { success = true, error = new { code = 202, message = "保存成功" }, fileUrl = filePathUrl, oldFileName = filePathName });
        }
        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="model">参数</param>
        /// <returns>JsonResult</returns>
        public JsonResult AddStockData(StockInfo model)
        {
            if (GetUserInfoEntity() == null)
            {
                Response.Status = "301 Moved Permanently";
                Response.StatusCode = 301;
                Response.AppendHeader("Location", "/Login");
            }
            else
            {
                //如果库存id存在时则更新该信息
                if (model.Id != Guid.Empty)
                {
                    var stockEntity = StockInfoBLL.Instance.GetStockInfoModel(model.Id);
                    stockEntity.ShopName = model.ShopName;
                    stockEntity.ShopNum = model.ShopNum;
                    stockEntity.ShopSource = model.ShopSource;
                    stockEntity.ShopPurchasePrice = model.ShopPurchasePrice;
                    stockEntity.ShopPrice = model.ShopPrice;
                    stockEntity.ShopRemark = model.ShopRemark;
                    stockEntity.UpdateBy = GetUserInfoEntity().Id;
                    stockEntity.UpdateDate=DateTime.Now;
                    ShopSystemBLL.StockInfoBLL.Instance.UpdateStockInfoModel(stockEntity, model.StockInfoItemList);
                }
                else
                {
                    model.Id = Guid.NewGuid();
                    model.CreateBy = GetUserInfoEntity().Id;
                    model.CreateDate = DateTime.Now;
                    model.UpdateBy = GetUserInfoEntity().Id;
                    model.UpdateDate=DateTime.Now;
                    model.Status = "ACTIVE";
                    ShopSystemBLL.StockInfoBLL.Instance.AddStockInfoData(model);
                }
                return Json(new { success = true, error = new { code = 202, message = "保存成功" } });
            }
            return Json(new { success = false, error = new { code = 301, message = "保存失败" } });
        }
        /// <summary>
        /// 删除库存信息
        /// </summary>
        /// <param name="delId">参数</param>
        /// <returns>JsonResult</returns>
        public JsonResult DelStockData(string delId)
        {
            if (!string.IsNullOrEmpty(delId))
            {
                var delResult = StockInfoBLL.Instance.DelStokListBuy(delId);
                if (delResult)
                {
                    return Json(new { success = true, error = new { code = 202, message = "删除成功" } });
                }
            }
            return Json(new { success = false, error = new { code = 301, message = "删除失败" } });
        }
    }
}
