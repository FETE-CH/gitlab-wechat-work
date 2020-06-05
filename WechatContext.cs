using Microsoft.EntityFrameworkCore;

using wechat_robot.Models;

namespace wechat_robot {
    public class WechatContext : DbContext {
        public WechatContext(DbContextOptions<WechatContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().Property(u => u.Uid).IsUnicode().UseSerialColumn();
            modelBuilder.Entity<User>().Property(u => u.CreatTime).HasDefaultValue();
            modelBuilder.Entity<User>().Property(u => u.UpdateTime).HasDefaultValue();
        }

        public DbSet<User> User { get; set; }
    }
}