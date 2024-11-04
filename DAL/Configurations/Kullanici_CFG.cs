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
    public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.Property(x => x.Ad)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Soyad)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.KullaniciAdi)
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsRequired();

            // Hash Seklinde tutulacak => Md5 algoritması
            builder.Property(x => x.Sifre)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();
         
            builder.Property(x => x.KullaniciTipi) 
                .HasConversion<string>() 
                .IsRequired();



        }
    }
}
