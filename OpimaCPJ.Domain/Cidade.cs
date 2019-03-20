using System;
using System.Collections.Generic;
using System.Text;

namespace OpimaCPJ.Domain
{
    public class Cidade
    {

        public Cidade()
        {
            Estado = new Estado();
            Bairros = new List<Bairro>();
        }

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public int CodigoEstado { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual ICollection<Bairro> Bairros { get; set; }

    }
}
