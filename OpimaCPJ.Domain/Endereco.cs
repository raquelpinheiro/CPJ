using System;
using System.Collections.Generic;

namespace OpimaCPJ.Domain
{
    public class Endereco : Entidade
    {
        public Endereco()
        {

        }
   
        public string Rua { get; set; }
        
        public string Numero { get; set; }

        public string Cep { get; set; }

        public string Complemento { get; set; }
        
        public string TipoEndereco { get; set; }

        public int? CodigoBairro { get; set; }

        public int? CodigoPessoa { get; set; }

        //public virtual Pessoa Bairro { get; set; }

    }

}