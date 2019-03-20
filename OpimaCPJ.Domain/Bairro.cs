using System;
using System.Collections.Generic;

namespace OpimaCPJ.Domain
{
    public class Bairro
    {

        public Bairro()
        {
            Cidade = new Cidade();
        }

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public int CodigoCidade { get; set; }

        public virtual Cidade Cidade { get; set; }


    }
}
