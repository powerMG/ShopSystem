using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ShopSystemEntity
{
    /// <summary>
    /// VipScoreBuyLog:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    [Table("Shop_VipScoreBuyLog")]
    public partial class VipScoreBuyLog
    {
        public VipScoreBuyLog()
        { }
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
        public Guid VipId
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int? BuyScore
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remoark
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

