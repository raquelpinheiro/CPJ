using System;
using System.Collections.Generic;
using System.Text;

namespace OpimaCPJ.Domain
{
    public class Estado
    {

        public Estado()
        {
            Cidades = new List<Cidade>();
        }

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }

    }
}
