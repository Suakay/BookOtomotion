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
    public class Yazar_CFG : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder.Property(x => x.YazarAdi)
                .HasColumnType("varchar")
                .HasMaxLength(55)
                .IsRequired();

            builder.Property(x => x.YazarSoyadi)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
