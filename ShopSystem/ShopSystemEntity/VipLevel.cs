using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemEntity
{
    [Table("Shop_VipLevel")]
    public class VipLevel
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
        public int? LevelNumber
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Score
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string LevelRemark
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Discount
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
