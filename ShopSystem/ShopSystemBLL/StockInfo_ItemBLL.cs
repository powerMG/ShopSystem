using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopSystemDAL;
using ShopSystemEntity;

namespace ShopSystemBLL
{
    public class StockInfo_ItemBLL
    {
        private StockInfo_ItemBLL()
        { }
        public static readonly StockInfo_ItemBLL Instance = new StockInfo_ItemBLL();
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
            return StockInfo_ItemDAL.instance.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(StockInfo_Item model)
		{
            return StockInfo_ItemDAL.instance.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(StockInfo_Item model)
		{
            return StockInfo_ItemDAL.instance.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Id)
		{
            return StockInfo_ItemDAL.instance.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
            return StockInfo_ItemDAL.instance.DeleteList(Idlist);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public StockInfo_Item GetModel(Guid Id)
		{
            return StockInfo_ItemDAL.instance.GetModel(Id);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            return StockInfo_ItemDAL.instance.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
            return StockInfo_ItemDAL.instance.GetList(Top, strWhere, filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<StockInfo_Item> GetModelList(string strWhere)
		{
            DataSet ds = StockInfo_ItemDAL.instance.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<StockInfo_Item> DataTableToList(DataTable dt)
		{
			List<StockInfo_Item> modelList = new List<StockInfo_Item>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				StockInfo_Item model;
				for (int n = 0; n < rowsCount; n++)
				{
                    model = StockInfo_ItemDAL.instance.DataRowToModel(dt.Rows[n]);
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
            return StockInfo_ItemDAL.instance.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
            return StockInfo_ItemDAL.instance.GetListByPage(strWhere, orderby, startIndex, endIndex);
		}
		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
    }
}
