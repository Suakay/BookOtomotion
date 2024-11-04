using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class YayinEvi_CFG : IEntityTypeConfiguration<YayinEvi>
    {
        public void Configure(EntityTypeBuilder<YayinEvi> builder)
        {
            builder.Property(x => x.YayinEviAdi)
                .HasColumnType("varchar")
                .HasMaxLength(55)
                .IsRequired();

        }
    }
}
