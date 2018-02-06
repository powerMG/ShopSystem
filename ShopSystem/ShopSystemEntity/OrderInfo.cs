using System;
namespace ShopSystemEntity
{
	/// <summary>
	/// OrderInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderInfo
	{
        public OrderInfo()
        { }
        #region Model
        private Guid _id;
        private Guid _stockid;
        private int? _buynum;
        private string _vipnumber;
        private int? _vipscore;
        private decimal? _orderprice;
        private string _orderremark;
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
        public Guid StockId
        {
            set { _stockid = value; }
            get { return _stockid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BuyNum
        {
            set { _buynum = value; }
            get { return _buynum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipNumber
        {
            set { _vipnumber = value; }
            get { return _vipnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VipScore
        {
            set { _vipscore = value; }
            get { return _vipscore; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OrderPrice
        {
            set { _orderprice = value; }
            get { return _orderprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrderRemark
        {
            set { _orderremark = value; }
            get { return _orderremark; }
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

	}
}

