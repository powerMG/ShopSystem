using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ShopSystemEntity;

namespace ShopSystemDAL
{
    public class UserInfoDAL
    {
        //单利模式
        private UserInfoDAL() { }
        public static readonly UserInfoDAL instance = new UserInfoDAL();

        private readonly DbHelper _db = new DbHelper();
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Shop_UserInfo");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            return _db.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Shop_UserInfo(");
            strSql.Append("Id,UserName,Password,Address,Sex,TelNum,PhoneNum,Status,CreateDate,CreateBy,UpdateDate,UpdateBy)");
            strSql.Append(" values (");
            strSql.Append("@Id,@UserName,@Password,@Address,@Sex,@TelNum,@PhoneNum,@Status,@CreateDate,@CreateBy,@UpdateDate,@UpdateBy)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Sex", SqlDbType.VarChar,5),
					new SqlParameter("@TelNum", SqlDbType.VarChar,20),
					new SqlParameter("@PhoneNum", SqlDbType.VarChar,20),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.Password;
            parameters[3].Value = model.Address;
            parameters[4].Value = model.Sex;
            parameters[5].Value = model.TelNum;
            parameters[6].Value = model.PhoneNum;
            parameters[7].Value = model.Status;
            parameters[8].Value = model.CreateDate;
            parameters[9].Value = Guid.NewGuid();
            parameters[10].Value = model.UpdateDate;
            parameters[11].Value = Guid.NewGuid();

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
        public bool Update(UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Shop_UserInfo set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("Password=@Password,");
            strSql.Append("Address=@Address,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("TelNum=@TelNum,");
            strSql.Append("PhoneNum=@PhoneNum,");
            strSql.Append("Status=@Status,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("CreateBy=@CreateBy,");
            strSql.Append("UpdateDate=@UpdateDate,");
            strSql.Append("UpdateBy=@UpdateBy");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,200),
					new SqlParameter("@Password", SqlDbType.VarChar,200),
					new SqlParameter("@Address", SqlDbType.Text),
					new SqlParameter("@Sex", SqlDbType.VarChar,5),
					new SqlParameter("@TelNum", SqlDbType.VarChar,20),
					new SqlParameter("@PhoneNum", SqlDbType.VarChar,20),
					new SqlParameter("@Status", SqlDbType.VarChar,20),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@CreateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateBy", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.Address;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.TelNum;
            parameters[5].Value = model.PhoneNum;
            parameters[6].Value = model.Status;
            parameters[7].Value = model.CreateDate;
            parameters[8].Value = model.CreateBy;
            parameters[9].Value = model.UpdateDate;
            parameters[10].Value = model.UpdateBy;
            parameters[11].Value = model.Id;

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
            strSql.Append("delete from Shop_UserInfo ");
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
            strSql.Append("delete from Shop_UserInfo ");
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
        public UserInfo GetModel(Guid Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,UserName,Password,Address,Sex,TelNum,PhoneNum,Status,CreateDate,CreateBy,UpdateDate,UpdateBy from Shop_UserInfo ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = Id;

            UserInfo model = new UserInfo();
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
        public UserInfo DataRowToModel(DataRow row)
        {
            UserInfo model = new UserInfo();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = new Guid(row["Id"].ToString());
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["Password"] != null)
                {
                    model.Password = row["Password"].ToString();
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["Sex"] != null)
                {
                    model.Sex = row["Sex"].ToString();
                }
                if (row["TelNum"] != null)
                {
                    model.TelNum = row["TelNum"].ToString();
                }
                if (row["PhoneNum"] != null)
                {
                    model.PhoneNum = row["PhoneNum"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = row["Status"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["CreateBy"] != null && row["CreateBy"].ToString() != "")
                {
                    model.CreateBy = new Guid(row["CreateBy"].ToString());
                }
                if (row["UpdateDate"] != null && row["UpdateDate"].ToString() != "")
                {
                    model.UpdateDate = DateTime.Parse(row["UpdateDate"].ToString());
                }
                if (row["UpdateBy"] != null && row["UpdateBy"].ToString() != "")
                {
                    model.UpdateBy = new Guid(row["UpdateBy"].ToString());
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
            strSql.Append("select Id,UserName,Password,Address,Sex,TelNum,PhoneNum,Status,CreateDate,CreateBy,UpdateDate,UpdateBy ");
            strSql.Append(" FROM Shop_UserInfo ");
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
            strSql.Append(" Id,UserName,Password,Address,Sex,TelNum,PhoneNum,Status,CreateDate,CreateBy,UpdateDate,UpdateBy ");
            strSql.Append(" FROM Shop_UserInfo ");
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
            strSql.Append("select count(1) FROM Shop_UserInfo ");
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
            strSql.Append(")AS Row, T.*  from Shop_UserInfo T ");
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
            parameters[0].Value = "Shop_UserInfo";
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
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UserInfo GetModel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,UserName,Password,Address,Sex,TelNum,PhoneNum,Status,CreateDate,CreateBy,UpdateDate,UpdateBy from Shop_UserInfo ");
            strSql.Append(" where 1=1 and ");
            if (!string.IsNullOrEmpty(strWhere))
            {
                strSql.Append(strWhere);
            }
            else
            {
                strSql.Append("1=-1");
            }
            DataSet ds = _db.Query(strSql.ToString());
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
        /// 获得前几行数据
        /// </summary>
        public List<UserInfo> GetArrayList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,UserName,Password,Address,Sex,TelNum,PhoneNum,Status,CreateDate,CreateBy,UpdateDate,UpdateBy ");
            strSql.Append(" FROM Shop_UserInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            if (!string.IsNullOrEmpty(filedOrder))
            {
                strSql.Append(" order by " + filedOrder);
            }
            else
            {
                strSql.Append(" order by CreateDate desc");
            }
            var dt = _db.QueryDataTable(strSql.ToString());
            return dt.Rows.Cast<DataRow>().Select(DataRowToModel).Where(infoItem => infoItem != null).ToList();
        }
        #endregion  ExtensionMethod
    }
}
