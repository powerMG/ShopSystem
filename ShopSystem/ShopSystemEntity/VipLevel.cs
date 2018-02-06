using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemEntity
{
    public class VipLevel
    {
        public VipLevel()
        { }
        #region Model
        private Guid _id;
        private int? _levelnumber;
        private int? _score;
        private string _levelremark;
        private decimal? _discount;
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
        public int? LevelNumber
        {
            set { _levelnumber = value; }
            get { return _levelnumber; }
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
        public string LevelRemark
        {
            set { _levelremark = value; }
            get { return _levelremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Discount
        {
            set { _discount = value; }
            get { return _discount; }
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
