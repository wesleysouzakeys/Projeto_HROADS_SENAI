using Microsoft.AspNetCore.Mvc;
using senai_hroads_webAPI.Interfaces;
using senai_hroads_webAPI.Repositories;
using senai_hroads_webAPI.LoginViewModels;

namespace senai_hroads_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginViewModel login)
        {
        }
    }
}
