using Microsoft.EntityFrameworkCore;
using OpimaCPJ.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OpimaCpj.Data.EntityConfig
{
    public class BairroConfig : IEntityTypeConfiguration<Bairro>
    {

        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.HasKey(c => c.Codigo);
       
            builder.HasOne(c => c.Cidade)
                        .WithMany(e => e.Bairros);

        }

    }
}
