using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ShopSystemEntity;

namespace ShopSystemDAL
{
    /// <summary>
    /// 数据访问类:VipScoreDAL
    /// </summary>
    public class VipScoreDAL
    {
        public VipScoreDAL()
        { }
        public static readonly VipScoreDAL instance = new VipScoreDAL();
        private readonly DbHelper _db = new DbHelper();
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Shop_VipScore");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            return _db.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(VipScore model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Shop_VipScore(");
            strSql.Append("Id,CardNumber,Score,VipName,VipPhone,VipSex,VipRemark,Status,VipLevelId,CreateBy,CreateDate,UpdateBy,UpdateDate)");
            strSql.Append(" values (");
            strSql.Append("@Id,@CardNumber,@Score,@VipName,@VipPhone,@VipSex,@VipRemark,@Status,@VipLevelId,@CreateBy,@CreateDate,@UpdateBy,@UpdateDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CardNumber", SqlDbType.NVarChar,-1),
					new SqlParameter("@Score", SqlDbType.Int,4),
					new SqlParameter("@VipName", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipPhone", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipSex", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("@Status", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipLevelId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.CardNumber;
            parameters[2].Value = model.Score;
            parameters[3].Value = model.VipName;
            parameters[4].Value = model.VipPhone;
            parameters[5].Value = model.VipSex;
            parameters[6].Value = model.VipRemark;
            parameters[7].Value = model.Status;
            parameters[8].Value = Guid.NewGuid();
            parameters[9].Value = Guid.NewGuid();
            parameters[10].Value = model.CreateDate;
            parameters[11].Value = Guid.NewGuid();
            parameters[12].Value = model.UpdateDate;

            int rows = _db.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(VipScore model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Shop_VipScore set ");
            strSql.Append("CardNumber=@CardNumber,");
            strSql.Append("Score=@Score,");
            strSql.Append("VipName=@VipName,");
            strSql.Append("VipPhone=@VipPhone,");
            strSql.Append("VipSex=@VipSex,");
            strSql.Append("VipRemark=@VipRemark,");
            strSql.Append("Status=@Status,");
            strSql.Append("VipLevelId=@VipLevelId,");
            strSql.Append("CreateBy=@CreateBy,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("UpdateBy=@UpdateBy,");
            strSql.Append("UpdateDate=@UpdateDate");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@CardNumber", SqlDbType.NVarChar,-1),
					new SqlParameter("@Score", SqlDbType.Int,4),
					new SqlParameter("@VipName", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipPhone", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipSex", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("@Status", SqlDbType.NVarChar,-1),
					new SqlParameter("@VipLevelId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.CardNumber;
            parameters[1].Value = model.Score;
            parameters[2].Value = model.VipName;
            parameters[3].Value = model.VipPhone;
            parameters[4].Value = model.VipSex;
            parameters[5].Value = model.VipRemark;
            parameters[6].Value = model.Status;
            parameters[7].Value = model.VipLevelId;
            parameters[8].Value = model.CreateBy;
            parameters[9].Value = model.CreateDate;
            parameters[10].Value = model.UpdateBy;
            parameters[11].Value = model.UpdateDate;
            parameters[12].Value = model.Id;

            int rows = _db.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Shop_VipScore ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            int rows = _db.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Shop_VipScore ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = _db.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public VipScore GetModel(Guid Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,CardNumber,Score,VipName,VipPhone,VipSex,VipRemark,Status,VipLevelId,CreateBy,CreateDate,UpdateBy,UpdateDate from Shop_VipScore ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            VipScore model = new VipScore();
            DataSet ds = _db.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public VipScore DataRowToModel(DataRow row)
        {
            VipScore model = new VipScore();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = new Guid(row["Id"].ToString());
                }
                if (row["CardNumber"] != null)
                {
                    model.CardNumber = row["CardNumber"].ToString();
                }
                if (row["Score"] != null && row["Score"].ToString() != "")
                {
                    model.Score = int.Parse(row["Score"].ToString());
                }
                if (row["VipName"] != null)
                {
                    model.VipName = row["VipName"].ToString();
                }
                if (row["VipPhone"] != null)
                {
                    model.VipPhone = row["VipPhone"].ToString();
                }
                if (row["VipSex"] != null)
                {
                    model.VipSex = row["VipSex"].ToString();
                }
                if (row["VipRemark"] != null)
                {
                    model.VipRemark = row["VipRemark"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = row["Status"].ToString();
                }
                if (row["VipLevelId"] != null && row["VipLevelId"].ToString() != "")
                {
                    model.VipLevelId = new Guid(row["VipLevelId"].ToString());
                }
                if (row["CreateBy"] != null && row["CreateBy"].ToString() != "")
                {
                    model.CreateBy = new Guid(row["CreateBy"].ToString());
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["UpdateBy"] != null && row["UpdateBy"].ToString() != "")
                {
                    model.UpdateBy = new Guid(row["UpdateBy"].ToString());
                }
                if (row["UpdateDate"] != null && row["UpdateDate"].ToString() != "")
                {
                    model.UpdateDate = DateTime.Parse(row["UpdateDate"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,CardNumber,Score,VipName,VipPhone,VipSex,VipRemark,Status,VipLevelId,CreateBy,CreateDate,UpdateBy,UpdateDate ");
            strSql.Append(" FROM Shop_VipScore ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return _db.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,CardNumber,Score,VipName,VipPhone,VipSex,VipRemark,Status,VipLevelId,CreateBy,CreateDate,UpdateBy,UpdateDate ");
            strSql.Append(" FROM Shop_VipScore ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return _db.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Shop_VipScore ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = _db.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from Shop_VipScore T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return _db.Query(strSql.ToString());
        }
        #endregion  BasicMethod
		#region  ExtensionMethod
        public List<VipScore> GetVipscoreListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            List<VipScore> stockLs = new List<VipScore>();
            DataSet ds_StockLs = GetListByPage(strWhere, orderby, startIndex, endIndex);
            if (ds_StockLs != null && ds_StockLs.Tables[0] != null && ds_StockLs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds_StockLs.Tables[0].Rows)
                {
                    VipScore stockModel = null;
                    stockModel = DataRowToModel(dr);
                    if (stockModel != null)
                    {
                        stockLs.Add(stockModel);
                    }
                }
            }
            return stockLs;
        }
		#endregion  ExtensionMethod
    }
}
