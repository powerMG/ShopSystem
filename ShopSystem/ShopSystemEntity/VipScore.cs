using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSystemEntity
{
    [Table("Shop_VipScore")]
    public class VipScore
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
        public string CardNumber
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
        public string VipName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipPhone
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipSex
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string VipRemark
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
        public Guid VipLevelId
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
