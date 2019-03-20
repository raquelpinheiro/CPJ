using Microsoft.EntityFrameworkCore;
using OpimaCPJ.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OpimaCpj.Data.EntityConfig
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(c => c.Codigo);
       
            // Colocar configurações para os demais campos da tabela
            // https://www.learnentityframeworkcore.com/configuration/one-to-many-relationship-configuration
            // https://www.learnentityframeworkcore.com/

            /*
            builder.HasOne(c => c.Cidade)
                        .WithMany(e => e.Bairros);

             */

        }

    }
}
