using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ShopSystemEntity;

namespace ShopSystemDAL
{
	/// <summary>
	/// 数据访问类:VipScoreBuyLog
	/// </summary>
	public partial class VipScoreBuyLogDAL
	{
        //单利模式
        private VipScoreBuyLogDAL()
		{}
        public static readonly VipScoreBuyLogDAL instance = new VipScoreBuyLogDAL();
        private readonly DbHelper _db = new DbHelper();
		#region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Shop_VipScoreBuyLog");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            return _db.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(VipScoreBuyLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Shop_VipScoreBuyLog(");
            strSql.Append("Id,VipId,BuyScore,Remoark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate)");
            strSql.Append(" values (");
            strSql.Append("@Id,@VipId,@BuyScore,@Remoark,@Status,@CreateBy,@CreateDate,@UpdateBy,@UpdateDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@VipId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@BuyScore", SqlDbType.Int,4),
					new SqlParameter("@Remoark", SqlDbType.VarChar,2000),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = Guid.NewGuid();
            parameters[2].Value = model.BuyScore;
            parameters[3].Value = model.Remoark;
            parameters[4].Value = model.Status;
            parameters[5].Value = Guid.NewGuid();
            parameters[6].Value = model.CreateDate;
            parameters[7].Value = Guid.NewGuid();
            parameters[8].Value = model.UpdateDate;

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
        public bool Update(VipScoreBuyLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Shop_VipScoreBuyLog set ");
            strSql.Append("VipId=@VipId,");
            strSql.Append("BuyScore=@BuyScore,");
            strSql.Append("Remoark=@Remoark,");
            strSql.Append("Status=@Status,");
            strSql.Append("CreateBy=@CreateBy,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("UpdateBy=@UpdateBy,");
            strSql.Append("UpdateDate=@UpdateDate");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@VipId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@BuyScore", SqlDbType.Int,4),
					new SqlParameter("@Remoark", SqlDbType.VarChar,2000),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.VipId;
            parameters[1].Value = model.BuyScore;
            parameters[2].Value = model.Remoark;
            parameters[3].Value = model.Status;
            parameters[4].Value = model.CreateBy;
            parameters[5].Value = model.CreateDate;
            parameters[6].Value = model.UpdateBy;
            parameters[7].Value = model.UpdateDate;
            parameters[8].Value = model.Id;

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
            strSql.Append("delete from Shop_VipScoreBuyLog ");
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
            strSql.Append("delete from Shop_VipScoreBuyLog ");
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
        public VipScoreBuyLog GetModel(Guid Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,VipId,BuyScore,Remoark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate from Shop_VipScoreBuyLog ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            VipScoreBuyLog model = new VipScoreBuyLog();
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
        public VipScoreBuyLog DataRowToModel(DataRow row)
        {
            VipScoreBuyLog model = new VipScoreBuyLog();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = new Guid(row["Id"].ToString());
                }
                if (row["VipId"] != null && row["VipId"].ToString() != "")
                {
                    model.VipId = new Guid(row["VipId"].ToString());
                }
                if (row["BuyScore"] != null && row["BuyScore"].ToString() != "")
                {
                    model.BuyScore = int.Parse(row["BuyScore"].ToString());
                }
                if (row["Remoark"] != null)
                {
                    model.Remoark = row["Remoark"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = row["Status"].ToString();
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
            strSql.Append("select Id,VipId,BuyScore,Remoark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate ");
            strSql.Append(" FROM Shop_VipScoreBuyLog ");
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
            strSql.Append(" Id,VipId,BuyScore,Remoark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate ");
            strSql.Append(" FROM Shop_VipScoreBuyLog ");
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
            strSql.Append("select count(1) FROM Shop_VipScoreBuyLog ");
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
            strSql.Append(")AS Row, T.*  from Shop_VipScoreBuyLog T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return _db.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Shop_VipScoreBuyLog";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return _db.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

