using Microsoft.EntityFrameworkCore;
using Models;
using System.Reflection;

namespace DAL
{
    public class SahafDBContext:DbContext
    {
       public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<YayinEvi> YayınEvleri { get; set; }
        public DbSet<Kullanici> Kullanıcılar { get; set; }
       
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-785CG1C;Initial Catalog=HS-16Kitapci;Integrated Security=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }


    }
}
