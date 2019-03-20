using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpimaCPJ.Domain
{
    public class PessoaFisica : Entidade
    {
        public PessoaFisica()
        {
            //Endereco = new HashSet<Endereco>();
        }

        public string TelefoneResidencial { get; set; }

        public string TelefoneCelular { get; set; }
        
        public string Nome { get; set; }
                
        public DateTime? DataNascimento { get; set; }
                
        public string Sexo { get; set; }
                
        public string Profissao { get; set; }
                
        public string Nacionalidade { get; set; }
                
        public string Email { get; set; }
                
        public string NomePai { get; set; }
                
        public string NomeMae { get; set; }
        
        public DateTime? DataCadastro { get; set; }
   
        public string Cpf { get; set; }
                           
        public string NumeroOAB { get; set; }

        //public int? codigo_posicao_parte { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }

        //public virtual Posicao Posicao { get; set; }
        
    }
}
