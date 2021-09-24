using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.LoginViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o E-Mail do Usuario!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha do Usuario!")]
        public string Senha { get; set; }
    }
}
