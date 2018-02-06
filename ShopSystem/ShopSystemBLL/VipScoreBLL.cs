using System;
using System.Data;
using System.Collections.Generic;
using ShopSystemDAL;
using ShopSystemEntity;
using ShopSystemTool;

namespace ShopSystemBLL
{
	/// <summary>
	/// VipScore
	/// </summary>
	public partial class VipScoreBLL
	{
        private VipScoreBLL()
        { }
        public static readonly VipScoreBLL Instance = new VipScoreBLL();
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Id)
        {
            return VipScoreDAL.instance.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(VipScore model)
        {
            return VipScoreDAL.instance.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(VipScore model)
        {
            return VipScoreDAL.instance.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid Id)
        {

            return VipScoreDAL.instance.Delete(Id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return VipScoreDAL.instance.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public VipScore GetModel(Guid Id)
        {

            return VipScoreDAL.instance.GetModel(Id);
        }

        
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return VipScoreDAL.instance.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return VipScoreDAL.instance.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<VipScore> GetModelList(string strWhere)
        {
            DataSet ds = VipScoreDAL.instance.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<VipScore> DataTableToList(DataTable dt)
        {
            List<VipScore> modelList = new List<VipScore>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                VipScore model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = VipScoreDAL.instance.DataRowToModel(dt.Rows[n]);
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
            return VipScoreDAL.instance.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return VipScoreDAL.instance.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return VipScoreDAL.instance.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public VipScore GetVipScroeModel(Guid Id)
        {
            var vipmodel = VipScoreDAL.instance.GetModel(Id);
            return vipmodel;
        }
        public List<VipScore> GetVipScoreListByPage(int pageIndex, int pagesize, string strWhere, string orderby)
        {
            int startIndex = (pageIndex - 1) * pagesize;
            int endIndex = pageIndex * pagesize;
            return VipScoreDAL.instance.GetVipscoreListByPage(strWhere, "", startIndex, endIndex);
        }
		#endregion  ExtensionMethod
	}
}

