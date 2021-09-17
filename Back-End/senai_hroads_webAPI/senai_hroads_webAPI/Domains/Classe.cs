using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webAPI.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            Classehabilidades = new HashSet<Classehabilidade>();
        }

        public byte IdClasse { get; set; }
        public string NomeClasse { get; set; }

        public virtual ICollection<Classehabilidade> Classehabilidades { get; set; }
    }
}
