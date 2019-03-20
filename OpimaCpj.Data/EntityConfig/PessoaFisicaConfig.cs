using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpimaCPJ.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpimaCpj.Data.EntityConfig
{
    public class PessoaFisicaConfig : IEntityTypeConfiguration<PessoaFisica>
    {

        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {

            builder.HasKey(c => c.Codigo);

        }
    }
}
