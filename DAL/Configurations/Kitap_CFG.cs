using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class Kitap_CFG : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.Property(x => x.KitapAdi)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Fiyat)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(x => x.BasimYili)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.ISBN)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(x => x.BaskiSayisi)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.KitapOzeti)
               .HasColumnType("varchar")
               .HasMaxLength(500)
               .IsRequired();

            builder.Property(x => x.AlmaTarihi)
           .HasColumnType("datetime")
           .IsRequired(false); // Nullable olduğu için bunu yaptım :)

            builder.Property(x => x.IadeTarihi)
                .HasColumnType("datetime")
                .IsRequired(false); 



        }
    }
}
