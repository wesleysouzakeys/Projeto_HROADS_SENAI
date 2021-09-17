using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webAPI.Domains
{
    public partial class Tipohabilidade
    {
        public Tipohabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public byte IdTipoHabilidade { get; set; }
        public string TipoHabilidade1 { get; set; }
        public byte Valor { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
