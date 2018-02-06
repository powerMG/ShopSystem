using System;
namespace ShopSystemEntity
{
	/// <summary>
	/// VipScoreBuyLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class VipScoreBuyLog
	{
        public VipScoreBuyLog()
        { }
        #region Model
        private Guid _id;
        private Guid _vipid;
        private int? _buyscore;
        private string _remoark;
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
        public Guid VipId
        {
            set { _vipid = value; }
            get { return _vipid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BuyScore
        {
            set { _buyscore = value; }
            get { return _buyscore; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remoark
        {
            set { _remoark = value; }
            get { return _remoark; }
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

