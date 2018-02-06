using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using ShopSystemDAL;
using ShopSystemEntity;

namespace ShopSystemBLL
{
	/// <summary>
	/// StockInfo
	/// </summary>
	public partial class StockInfoBLL
	{
        private StockInfoBLL()
        { }
        public static readonly StockInfoBLL Instance = new StockInfoBLL();
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
			return StockInfoDAL.instance.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(StockInfo model)
		{
			return StockInfoDAL.instance.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(StockInfo model)
		{
			return StockInfoDAL.instance.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Id)
		{
			
			return StockInfoDAL.instance.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return StockInfoDAL.instance.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public StockInfo GetModel(Guid Id)
		{
			return StockInfoDAL.instance.GetModel(Id);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return StockInfoDAL.instance.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return StockInfoDAL.instance.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<StockInfo> GetModelList(string strWhere)
		{
			DataSet ds = StockInfoDAL.instance.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<StockInfo> DataTableToList(DataTable dt)
		{
			List<StockInfo> modelList = new List<StockInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				StockInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = StockInfoDAL.instance.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return StockInfoDAL.instance.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return StockInfoDAL.instance.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		#endregion  BasicMethod
		#region  ExtensionMethod

        public List<StockInfo> GetStockListByPage(int pageIndex, int pagesize, string strWhere, string orderby)
        {
            int startIndex = (pageIndex - 1) * pagesize;
            int endIndex=pageIndex * pagesize;
            return StockInfoDAL.instance.GetStockListByPage(strWhere, "", startIndex, endIndex);
	    }
        /// <summary>
        /// 批量删除数据（逻辑删除）
        /// </summary>
        /// <param name="delids">主键id</param>
        /// <returns>bool</returns>
	    public bool DelStokListBuy(string delids)
	    {
	        if (!string.IsNullOrEmpty(delids))
	        {
	            var arrDelid = delids.Split('|');
                foreach (var item in arrDelid)
                {
                    var model = StockInfoDAL.instance.GetModel(Guid.Parse(item));
                    if (model != null)
                    {
                        model.Status = "DELETE";
                        StockInfoDAL.instance.Update(model);
                    }
	            }
	            return true;
	        }
	        else
	        {
	            return false;
	        }
	    }
        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="model">商品参数</param>
        /// <returns>bool</returns>
	    public bool AddStockInfoData(StockInfo model)
	    {
	        if (model.StockInfoItemList != null && model.StockInfoItemList.Any())
	        {
                //添加主商品信息
	            if (StockInfoDAL.instance.Add(model))
	            {
                    //添加商品详情信息
                    foreach (var stckinfoItem in model.StockInfoItemList)
                    {
                        //添加商品详细信息
                        stckinfoItem.Id = Guid.NewGuid();
                        stckinfoItem.StockInfoId = model.Id;
                        stckinfoItem.CreateBy = model.CreateBy;
                        stckinfoItem.CreateDate = DateTime.Now;
                        stckinfoItem.UpdateBy = model.CreateBy;
                        stckinfoItem.UpdateDate = DateTime.Now;
                        StockInfo_ItemDAL.instance.Add(stckinfoItem);
                    }
	            }
	            return true;
	        }
	        return false;
	    }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public StockInfo GetStockInfoModel(Guid Id)
        {
            var stockmodel = StockInfoDAL.instance.GetModel(Id);
            var stockIntItemLs=StockInfo_ItemDAL.instance.GetStockList(0, string.Format("StockInfoId='{0}'", Id), "");
            stockmodel.StockInfoItemList = stockIntItemLs;
            return stockmodel;
        }

	    /// <summary>
	    /// 更新库存信息
	    /// </summary>
	    /// <param name="model">参数</param>
	    /// <param name="stockitemLs">库存详细信息列表</param>
	    /// <returns>bool</returns>
        public bool UpdateStockInfoModel(StockInfo model, IList<StockInfo_Item> stockitemLs)
        {
            if (StockInfoDAL.instance.Update(model))
            {
                if (model.StockInfoItemList!=null&&model.StockInfoItemList.Any()&&stockitemLs != null && stockitemLs.Any())
                {
                    for (var i=0;i<model.StockInfoItemList.Count;i++)
                    {
                        model.StockInfoItemList[i].ShopNumber = stockitemLs[i].ShopNumber;
                        model.StockInfoItemList[i].Color = stockitemLs[i].Color;
                        model.StockInfoItemList[i].Size = stockitemLs[i].Size;
                        model.StockInfoItemList[i].Number = stockitemLs[i].Number;
                        model.StockInfoItemList[i].UpdateBy = model.UpdateBy;
                        model.StockInfoItemList[i].UpdateDate = model.UpdateDate;
                        StockInfo_ItemDAL.instance.Update(model.StockInfoItemList[i]);
                    }
                }
                return true;
            }
            return false;
        }
	    #endregion  ExtensionMethod
	}
}

