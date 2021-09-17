using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webAPI.Domains
{
    public partial class Usuario
    {
        public short IdUsuario { get; set; }
        public short? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
    }
}
