using System;
using System.Collections.Generic;
using System.Text;

namespace Opima.CPJ.Application.ViewModel
{
    public class PessoaFisicaViewModel
    {

        public int Codigo { get; set; }

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

        public IEnumerable<EnderecoViewModel> Enderecos { get; set; }

    }

}
