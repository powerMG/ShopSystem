using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemEntity
{
    /// <summary>
    /// StockInfo_Item:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    [Table("Shop_StockInfo_Item")]
    public class StockInfo_Item
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
        public Guid StockInfoId
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShopNumber
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Size
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Color
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Number
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
