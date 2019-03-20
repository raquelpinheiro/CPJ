using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpimaCPJ.Domain
{
    public class Posicao : Entidade
    {
        public Posicao()
        {
            Pessoa = new List<PessoaFisica>();
        }

        public string Descricao { get; set; }

        public virtual ICollection<PessoaFisica> Pessoa { get; set; }

    }
}

