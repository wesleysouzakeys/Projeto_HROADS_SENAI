using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webAPI.Domains
{
    public partial class Personagem
    {
        public byte IdPersonagem { get; set; }
        public byte? IdClasseHabi { get; set; }
        public string NomePersonagem { get; set; }
        public byte QtdMaxVida { get; set; }
        public byte QtdMaxMana { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual Classehabilidade IdClasseHabiNavigation { get; set; }
    }
}
