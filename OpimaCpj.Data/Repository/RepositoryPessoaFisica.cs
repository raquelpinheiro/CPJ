using OpimaCpj.Data.Context;
using OpimaCPJ.Domain;
using OpimaCPJ.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OpimaCpj.Data.Repository
{

    public class RepositoryPessoaFisica : Repository<PessoaFisica>, IRepositoryPessoaFisica 
    {
    
     public RepositoryPessoaFisica(OpimaCpjContext repositoryContext)
            :base(repositoryContext)
        {
        }
    
    }

}