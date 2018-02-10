using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystemEntity
{
    [Table("Shop_UserInfo")]
    public class UserInfo
    {
        #region Model        
        /// <summary>
        /// 
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TelNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid CreateBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Guid UpdateBy { get; set; }
        #endregion Model

    }
}
