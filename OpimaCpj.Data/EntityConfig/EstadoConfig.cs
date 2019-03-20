using OpimaCPJ.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OpimaCpj.Data.EntityConfig
{
    public class EstadoConfig : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(a => a.Codigo);

            builder.Property(a => a.Nome).IsRequired().HasMaxLength(60);
            
            //builder.ToTable("Estados");

        }

    }
}
