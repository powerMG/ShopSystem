using System;
using System.Data;
using System.Collections.Generic;
using ShopSystemDAL;
using ShopSystemEntity;

namespace ShopSystemBLL
{
	/// <summary>
	/// VipScoreBuyLog
	/// </summary>
	public partial class VipScoreBuyLogBLL
	{
        private VipScoreBuyLogBLL()
        { }
        public static readonly VipScoreBuyLogBLL Instance = new VipScoreBuyLogBLL();
		#region
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
			return VipScoreBuyLogDAL.instance.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(VipScoreBuyLog model)
		{
			return VipScoreBuyLogDAL.instance.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(VipScoreBuyLog model)
		{
			return VipScoreBuyLogDAL.instance.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Id)
		{
			
			return VipScoreBuyLogDAL.instance.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return VipScoreBuyLogDAL.instance.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public VipScoreBuyLog GetModel(Guid Id)
		{
			
			return VipScoreBuyLogDAL.instance.GetModel(Id);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return VipScoreBuyLogDAL.instance.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return VipScoreBuyLogDAL.instance.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<VipScoreBuyLog> GetModelList(string strWhere)
		{
			DataSet ds = VipScoreBuyLogDAL.instance.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<VipScoreBuyLog> DataTableToList(DataTable dt)
		{
			List<VipScoreBuyLog> modelList = new List<VipScoreBuyLog>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				VipScoreBuyLog model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = VipScoreBuyLogDAL.instance.DataRowToModel(dt.Rows[n]);
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
			return VipScoreBuyLogDAL.instance.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return VipScoreBuyLogDAL.instance.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return VipScoreBuyLogDAL.instance.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion
		#region  自定义方法

		#endregion
	}
}

