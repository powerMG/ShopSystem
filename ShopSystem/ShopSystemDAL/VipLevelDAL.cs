using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopSystemEntity;

namespace ShopSystemDAL
{
    public class VipLevelDAL
    {
        public VipLevelDAL()
        { }
        public static readonly VipLevelDAL instance = new VipLevelDAL();
        private readonly DbHelper _db = new DbHelper();
        #region
        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Shop_VipLevel");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = Id;

			return _db.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(VipLevel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Shop_VipLevel(");
			strSql.Append("Id,VipLevel,Score,LevelRemark,Discount,Status,CreateBy,CreateDate,UpdateBy,UpdateDate)");
			strSql.Append(" values (");
			strSql.Append("@Id,@VipLevel,@Score,@LevelRemark,@Discount,@Status,@CreateBy,@CreateDate,@UpdateBy,@UpdateDate)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@VipLevel", SqlDbType.Int,4),
					new SqlParameter("@Score", SqlDbType.Int,4),
					new SqlParameter("@LevelRemark", SqlDbType.Text),
					new SqlParameter("@Discount", SqlDbType.Float,8),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime)};
			parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.LevelNumber;
			parameters[2].Value = model.Score;
			parameters[3].Value = model.LevelRemark;
			parameters[4].Value = model.Discount;
			parameters[5].Value = model.Status;
			parameters[6].Value = Guid.NewGuid();
			parameters[7].Value = model.CreateDate;
			parameters[8].Value = Guid.NewGuid();
			parameters[9].Value = model.UpdateDate;

			int rows=_db.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(VipLevel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Shop_VipLevel set ");
			strSql.Append("VipLevel=@VipLevel,");
			strSql.Append("Score=@Score,");
			strSql.Append("LevelRemark=@LevelRemark,");
			strSql.Append("Discount=@Discount,");
			strSql.Append("Status=@Status,");
			strSql.Append("CreateBy=@CreateBy,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("UpdateBy=@UpdateBy,");
			strSql.Append("UpdateDate=@UpdateDate");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@VipLevel", SqlDbType.Int,4),
					new SqlParameter("@Score", SqlDbType.Int,4),
					new SqlParameter("@LevelRemark", SqlDbType.Text),
					new SqlParameter("@Discount", SqlDbType.Float,8),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.LevelNumber;
			parameters[1].Value = model.Score;
			parameters[2].Value = model.LevelRemark;
			parameters[3].Value = model.Discount;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.CreateBy;
			parameters[6].Value = model.CreateDate;
			parameters[7].Value = model.UpdateBy;
			parameters[8].Value = model.UpdateDate;
			parameters[9].Value = model.Id;

			int rows=_db.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Shop_VipLevel ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = Id;

			int rows=_db.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Shop_VipLevel ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=_db.ExecuteSql(strSql.ToString());
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
		public VipLevel GetModel(Guid Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,VipLevel,Score,LevelRemark,Discount,Status,CreateBy,CreateDate,UpdateBy,UpdateDate from Shop_VipLevel ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
			parameters[0].Value = Id;

			VipLevel model=new VipLevel();
			DataSet ds=_db.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public VipLevel DataRowToModel(DataRow row)
		{
			VipLevel model=new VipLevel();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id= new Guid(row["Id"].ToString());
				}
                if (row["LevelNumber"] != null && row["LevelNumber"].ToString() != "")
				{
                    model.LevelNumber = int.Parse(row["LevelNumber"].ToString());
				}
				if(row["Score"]!=null && row["Score"].ToString()!="")
				{
					model.Score=int.Parse(row["Score"].ToString());
				}
				if(row["LevelRemark"]!=null)
				{
					model.LevelRemark=row["LevelRemark"].ToString();
				}
				if(row["Discount"]!=null && row["Discount"].ToString()!="")
				{
					model.Discount=decimal.Parse(row["Discount"].ToString());
				}
				if(row["Status"]!=null)
				{
					model.Status=row["Status"].ToString();
				}
				if(row["CreateBy"]!=null && row["CreateBy"].ToString()!="")
				{
					model.CreateBy= new Guid(row["CreateBy"].ToString());
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["UpdateBy"]!=null && row["UpdateBy"].ToString()!="")
				{
					model.UpdateBy= new Guid(row["UpdateBy"].ToString());
				}
				if(row["UpdateDate"]!=null && row["UpdateDate"].ToString()!="")
				{
					model.UpdateDate=DateTime.Parse(row["UpdateDate"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,VipLevel,Score,LevelRemark,Discount,Status,CreateBy,CreateDate,UpdateBy,UpdateDate ");
			strSql.Append(" FROM Shop_VipLevel ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return _db.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,VipLevel,Score,LevelRemark,Discount,Status,CreateBy,CreateDate,UpdateBy,UpdateDate ");
			strSql.Append(" FROM Shop_VipLevel ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return _db.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Shop_VipLevel ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from Shop_VipLevel T ");
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
			parameters[0].Value = "Shop_VipLevel";
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
