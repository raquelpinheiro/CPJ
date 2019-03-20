using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Entity.ModelConfiguration;
using OpimaCPJ.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OpimaCpj.Data.EntityConfig
{
    public class CidadeConfig : IEntityTypeConfiguration<Cidade>
    {

        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(c => c.Codigo);

            /* 
            builder.Property(c=> c.EstadoCidade).IsRequired()
            .WithMany(p => p.Cidades)
            .HasForeignKey(a => a.CodigoEstado);
            */
                  
             builder.HasMany(c => c.Bairros)
                        .WithOne(e => e.Cidade);

             builder.HasOne(c => c.Estado)
                        .WithMany(e => e.Cidades);

        }
    }
}
