using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemEntity
{
    /// <summary>
    /// StockInfo_Item:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class StockInfo_Item
    {
        public StockInfo_Item()
        { }
        #region Model
        private Guid _id;
        private Guid _stockinfoid;
        private string _shopnumber;
        private string _size;
        private string _color;
        private int? _number;
        private Guid _createby;
        private DateTime? _createdate;
        private Guid _updateby;
        private DateTime? _updatedate;
        /// <summary>
        /// 
        /// </summary>
        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid StockInfoId
        {
            set { _stockinfoid = value; }
            get { return _stockinfoid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopNumber
        {
            set { _shopnumber = value; }
            get { return _shopnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Size
        {
            set { _size = value; }
            get { return _size; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Color
        {
            set { _color = value; }
            get { return _color; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Number
        {
            set { _number = value; }
            get { return _number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid CreateBy
        {
            set { _createby = value; }
            get { return _createby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid UpdateBy
        {
            set { _updateby = value; }
            get { return _updateby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateDate
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        #endregion Model

    }
}
