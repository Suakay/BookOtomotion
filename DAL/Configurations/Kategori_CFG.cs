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
    public class Kategori_CFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.Property(x => x.KategoriAdi)
                .HasColumnType("varchar")
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
