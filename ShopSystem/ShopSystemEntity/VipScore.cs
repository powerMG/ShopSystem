using System;

namespace ShopSystemEntity
{
    public class VipScore
    {
        public VipScore()
        { }
        #region Model
        private Guid _id;
        private int? _cardnumber;
        private int? _score;
        private string _vipname;
        private int? _vipphone;
        private string _vipsex;
        private string _vipremark;
        private string _status;
        private Guid _viplevelid;
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
        public int? CardNumber
        {
            set { _cardnumber = value; }
            get { return _cardnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Score
        {
            set { _score = value; }
            get { return _score; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipName
        {
            set { _vipname = value; }
            get { return _vipname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VipPhone
        {
            set { _vipphone = value; }
            get { return _vipphone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipSex
        {
            set { _vipsex = value; }
            get { return _vipsex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipRemark
        {
            set { _vipremark = value; }
            get { return _vipremark; }
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
        public Guid VipLevelId
        {
            set { _viplevelid = value; }
            get { return _viplevelid; }
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
