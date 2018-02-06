using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopSystemDAL;
using ShopSystemEntity;

namespace ShopSystemBLL
{
    public class UserInfoBLL
    {
        private UserInfoBLL()
        {
        }
        public static readonly UserInfoBLL Instance = new UserInfoBLL();

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UserInfo GetModel(Guid id)
        {
            return UserInfoDAL.instance.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public UserInfo GetModel(string strWhere)
        {
            return UserInfoDAL.instance.GetModel(strWhere);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<UserInfo> GetArrayList(int Top, string strWhere, string filedOrder)
        {
            return UserInfoDAL.instance.GetArrayList(Top, strWhere, filedOrder);
        }
    }
}
