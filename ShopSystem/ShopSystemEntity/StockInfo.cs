using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ShopSystemEntity
{
    /// <summary>
    /// StockInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    [Table("Shop_StockInfo")]
    public partial class StockInfo
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
        public string ShopImg
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopImgName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ShopNum
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopSource
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ShopPurchasePrice
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ShopPrice
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopRemark
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
        #region 辅助扩展字段
        [NotMapped]
        public IList<StockInfo_Item> StockInfoItemList { get; set; }
        #endregion
    }
}

