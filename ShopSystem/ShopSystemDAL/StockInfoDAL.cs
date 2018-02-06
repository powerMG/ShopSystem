using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ShopSystemEntity;

namespace ShopSystemDAL
{
	/// <summary>
	/// 数据访问类:StockInfo
	/// </summary>
	public partial class StockInfoDAL
	{
        private StockInfoDAL()
		{}
        public static readonly StockInfoDAL instance = new StockInfoDAL();
        private readonly DbHelper _db = new DbHelper();
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Shop_StockInfo");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            return _db.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(StockInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Shop_StockInfo(");
            strSql.Append("Id,ShopImg,ShopImgName,ShopName,ShopNum,ShopSource,ShopPurchasePrice,ShopPrice,ShopRemark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate)");
            strSql.Append(" values (");
            strSql.Append("@Id,@ShopImg,@ShopImgName,@ShopName,@ShopNum,@ShopSource,@ShopPurchasePrice,@ShopPrice,@ShopRemark,@Status,@CreateBy,@CreateDate,@UpdateBy,@UpdateDate)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ShopImg", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopImgName", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopName", SqlDbType.NVarChar,300),
					new SqlParameter("@ShopNum", SqlDbType.Int,4),
					new SqlParameter("@ShopSource", SqlDbType.NVarChar,500),
					new SqlParameter("@ShopPurchasePrice", SqlDbType.Decimal,9),
					new SqlParameter("@ShopPrice", SqlDbType.Decimal,9),
					new SqlParameter("@ShopRemark", SqlDbType.NVarChar,500),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.ShopImg;
            parameters[2].Value = model.ShopImgName;
            parameters[3].Value = model.ShopName;
            parameters[4].Value = model.ShopNum;
            parameters[5].Value = model.ShopSource;
            parameters[6].Value = model.ShopPurchasePrice;
            parameters[7].Value = model.ShopPrice;
            parameters[8].Value = model.ShopRemark;
            parameters[9].Value = model.Status;
            parameters[10].Value = model.CreateBy;
            parameters[11].Value = model.CreateDate;
            parameters[12].Value = model.UpdateBy;
            parameters[13].Value = model.UpdateDate;

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
        public bool Update(StockInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Shop_StockInfo set ");
            strSql.Append("ShopImg=@ShopImg,");
            strSql.Append("ShopImgName=@ShopImgName,");
            strSql.Append("ShopName=@ShopName,");
            strSql.Append("ShopNum=@ShopNum,");
            strSql.Append("ShopSource=@ShopSource,");
            strSql.Append("ShopPurchasePrice=@ShopPurchasePrice,");
            strSql.Append("ShopPrice=@ShopPrice,");
            strSql.Append("ShopRemark=@ShopRemark,");
            strSql.Append("Status=@Status,");
            strSql.Append("CreateBy=@CreateBy,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("UpdateBy=@UpdateBy,");
            strSql.Append("UpdateDate=@UpdateDate");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@ShopImg", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopImgName", SqlDbType.NVarChar,200),
					new SqlParameter("@ShopName", SqlDbType.NVarChar,300),
					new SqlParameter("@ShopNum", SqlDbType.Int,4),
					new SqlParameter("@ShopSource", SqlDbType.NVarChar,500),
					new SqlParameter("@ShopPurchasePrice", SqlDbType.Decimal,9),
					new SqlParameter("@ShopPrice", SqlDbType.Decimal,9),
					new SqlParameter("@ShopRemark", SqlDbType.NVarChar,500),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.ShopImg;
            parameters[1].Value = model.ShopImgName;
            parameters[2].Value = model.ShopName;
            parameters[3].Value = model.ShopNum;
            parameters[4].Value = model.ShopSource;
            parameters[5].Value = model.ShopPurchasePrice;
            parameters[6].Value = model.ShopPrice;
            parameters[7].Value = model.ShopRemark;
            parameters[8].Value = model.Status;
            parameters[9].Value = model.CreateBy;
            parameters[10].Value = model.CreateDate;
            parameters[11].Value = model.UpdateBy;
            parameters[12].Value = model.UpdateDate;
            parameters[13].Value = model.Id;

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
            strSql.Append("delete from Shop_StockInfo ");
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
            strSql.Append("delete from Shop_StockInfo ");
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
        public StockInfo GetModel(Guid Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,ShopImg,ShopImgName,ShopName,ShopNum,ShopSource,ShopPurchasePrice,ShopPrice,ShopRemark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate from Shop_StockInfo ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            StockInfo model = new StockInfo();
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
        public StockInfo DataRowToModel(DataRow row)
        {
            StockInfo model = new StockInfo();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = new Guid(row["Id"].ToString());
                }
                if (row["ShopImg"] != null)
                {
                    model.ShopImg = row["ShopImg"].ToString();
                }
                if (row["ShopImgName"] != null)
                {
                    model.ShopImgName = row["ShopImgName"].ToString();
                }
                if (row["ShopName"] != null)
                {
                    model.ShopName = row["ShopName"].ToString();
                }
                if (row["ShopNum"] != null && row["ShopNum"].ToString() != "")
                {
                    model.ShopNum = int.Parse(row["ShopNum"].ToString());
                }
                if (row["ShopSource"] != null)
                {
                    model.ShopSource = row["ShopSource"].ToString();
                }
                if (row["ShopPurchasePrice"] != null && row["ShopPurchasePrice"].ToString() != "")
                {
                    model.ShopPurchasePrice = decimal.Parse(row["ShopPurchasePrice"].ToString());
                }
                if (row["ShopPrice"] != null && row["ShopPrice"].ToString() != "")
                {
                    model.ShopPrice = decimal.Parse(row["ShopPrice"].ToString());
                }
                if (row["ShopRemark"] != null)
                {
                    model.ShopRemark = row["ShopRemark"].ToString();
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
            strSql.Append("select Id,ShopImg,ShopImgName,ShopName,ShopNum,ShopSource,ShopPurchasePrice,ShopPrice,ShopRemark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate ");
            strSql.Append(" FROM Shop_StockInfo ");
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
            strSql.Append(" Id,ShopImg,ShopImgName,ShopName,ShopNum,ShopSource,ShopPurchasePrice,ShopPrice,ShopRemark,Status,CreateBy,CreateDate,UpdateBy,UpdateDate ");
            strSql.Append(" FROM Shop_StockInfo ");
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
            strSql.Append("select count(1) FROM Shop_StockInfo ");
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
            strSql.Append(")AS Row, T.*  from Shop_StockInfo T ");
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
            parameters[0].Value = "Shop_StockInfo";
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

        public List<StockInfo> GetStockListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            List<StockInfo> stockLs = new List<StockInfo>();
	        DataSet ds_StockLs=GetListByPage(strWhere,orderby,startIndex,endIndex);
            if (ds_StockLs != null && ds_StockLs.Tables[0] !=null&& ds_StockLs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds_StockLs.Tables[0].Rows)
                {
                    StockInfo stockModel = null;
                    stockModel = DataRowToModel(dr);
                    if (stockModel != null)
                    {
                        stockLs.Add(stockModel);
                    }
                }
            }
            return stockLs;
        }
        /// <summary>
        /// 根据条件得到商品信息
        /// </summary>
        /// <param name="top">返回条数</param>
        /// <param name="strWhere">条件</param>
        /// <param name="orderby">排序</param>
        /// <returns>List<StockInfo/></returns>
        public List<StockInfo> GetStockList(int top,string strWhere, string orderby)
        {
            List<StockInfo> stockLs = new List<StockInfo>();
            DataSet dsStockLs = GetList(top, strWhere, orderby);
            if (dsStockLs != null && dsStockLs.Tables[0] != null && dsStockLs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsStockLs.Tables[0].Rows)
                {
                    StockInfo stockModel = null;
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

