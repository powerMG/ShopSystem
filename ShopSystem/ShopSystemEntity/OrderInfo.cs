using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ShopSystemEntity
{
	/// <summary>
	/// OrderInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Shop_OrderInfo")]
    [Serializable]
	public partial class OrderInfo
	{
        #region Model
        /// <summary>
        /// 
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid StockId
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BuyNum
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipNumber
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VipScore
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OrderPrice
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrderRemark
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Status
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid CreateBy
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public Guid UpdateBy
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateDate
        {
            set;
            get;
        }
        #endregion Model

	}
}

