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
    public class VipLevelBLL
    {
        private VipLevelBLL()
        { }
        public static readonly VipLevelBLL Instance = new VipLevelBLL();
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Id)
        {
            return VipLevelDAL.instance.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(VipLevel model)
        {
            return VipLevelDAL.instance.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(VipLevel model)
        {
            return VipLevelDAL.instance.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid Id)
        {

            return VipLevelDAL.instance.Delete(Id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return VipLevelDAL.instance.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public VipLevel GetModel(Guid Id)
        {
            return VipLevelDAL.instance.GetModel(Id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return VipLevelDAL.instance.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return VipLevelDAL.instance.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<VipLevel> GetModelList(string strWhere)
        {
            DataSet ds = VipLevelDAL.instance.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<VipLevel> DataTableToList(DataTable dt)
        {
            List<VipLevel> modelList = new List<VipLevel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                VipLevel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = VipLevelDAL.instance.DataRowToModel(dt.Rows[n]);
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
            return VipLevelDAL.instance.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return VipLevelDAL.instance.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
