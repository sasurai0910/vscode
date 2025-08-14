using Microsoft.EntityFrameworkCore;

namespace MyMvcApp.Data  // ← ここをプロジェクト名に合わせる
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerInput> InputDatas { get; set; }
    }
}
