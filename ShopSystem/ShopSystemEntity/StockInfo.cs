using System;
using System.Collections.Generic;

namespace ShopSystemEntity
{
    /// <summary>
    /// StockInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class StockInfo
    {
        public StockInfo()
        { }
        #region Model
        private Guid _id;
        private string _shopimg;
        private string _shopimgname;
        private string _shopname;
        private int? _shopnum;
        private string _shopsource;
        private decimal? _shoppurchaseprice;
        private decimal? _shopprice;
        private string _shopremark;
        private string _status;
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
        public string ShopImg
        {
            set { _shopimg = value; }
            get { return _shopimg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopImgName
        {
            set { _shopimgname = value; }
            get { return _shopimgname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopName
        {
            set { _shopname = value; }
            get { return _shopname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ShopNum
        {
            set { _shopnum = value; }
            get { return _shopnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopSource
        {
            set { _shopsource = value; }
            get { return _shopsource; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ShopPurchasePrice
        {
            set { _shoppurchaseprice = value; }
            get { return _shoppurchaseprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ShopPrice
        {
            set { _shopprice = value; }
            get { return _shopprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopRemark
        {
            set { _shopremark = value; }
            get { return _shopremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Status
        {
            set { _status = value; }
            get { return _status; }
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
        #region 辅助扩展字段
        public IList<StockInfo_Item> StockInfoItemList { get; set; }
        #endregion
    }
}

