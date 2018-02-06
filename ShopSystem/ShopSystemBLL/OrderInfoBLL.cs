using System;
using System.Data;
using System.Collections.Generic;
using ShopSystemDAL;
using ShopSystemEntity;

namespace ShopSystemBLL
{
	/// <summary>
	/// OrderInfo
	/// </summary>
	public partial class OrderInfoBLL
	{
        private OrderInfoBLL()
		{}
        public static readonly OrderInfoBLL Instance = new OrderInfoBLL();
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
			return OrderInfoDAL.instance.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(OrderInfo model)
		{
			return OrderInfoDAL.instance.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(OrderInfo model)
		{
			return OrderInfoDAL.instance.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Id)
		{
			
			return OrderInfoDAL.instance.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return OrderInfoDAL.instance.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public OrderInfo GetModel(Guid Id)
		{
			
			return OrderInfoDAL.instance.GetModel(Id);
		}
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return OrderInfoDAL.instance.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return OrderInfoDAL.instance.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<OrderInfo> GetModelList(string strWhere)
		{
			DataSet ds = OrderInfoDAL.instance.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<OrderInfo> DataTableToList(DataTable dt)
		{
			List<OrderInfo> modelList = new List<OrderInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				OrderInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = OrderInfoDAL.instance.DataRowToModel(dt.Rows[n]);
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
			return OrderInfoDAL.instance.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return OrderInfoDAL.instance.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return OrderInfoDAL.instance.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

