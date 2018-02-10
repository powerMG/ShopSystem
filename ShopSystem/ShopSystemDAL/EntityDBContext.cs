using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShopSystemEntity;


namespace ShopSystemDAL
{
    public class EntityDBContext : DbContext
    {
        //public static readonly EntityDBContext instance = new EntityDBContext();
        public EntityDBContext()
            : base("ConnectionString")
        { 
        }
        public DbSet<OrderInfo> Orderinfo { get; set; }
        public DbSet<StockInfo> StockInfo { get; set; }
        public DbSet<StockInfo_Item> StockInfo_Item { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<VipLevel> VipLevel { get; set; }
        public DbSet<VipScore> VipScore { get; set; }
        public DbSet<VipScoreBuyLog> VipScoreBuyLog { get; set; }
    }
}
