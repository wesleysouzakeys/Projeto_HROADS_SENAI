using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using senai_hroads_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }

        public PersonagensController()
        {
            _personagemRepository = new PersonagemRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_personagemRepository.Listar());
        }

        [HttpGet("{idPersonagem}")]
        public IActionResult BuscarPorId(int idPersonagem)
        {
            return Ok(_personagemRepository.BuscarPorId(idPersonagem));
        }

        [HttpPost]
        public IActionResult Cadastrar(Personagem novaPersonagem)
        {
            _personagemRepository.Cadastrar(novaPersonagem);

            return StatusCode(201);
        }

        [HttpPut("{idPersonagem}")]
        public IActionResult Atualizar(int idPersonagem, Personagem habilidadeAtualizada)
        {
            _personagemRepository.AtualizarIdUrl(idPersonagem, habilidadeAtualizada);
            return StatusCode(204);
        }

        [HttpDelete("{idPersonagem}")]
        public IActionResult Deletar(int idPersonagem)
        {
            _personagemRepository.Deletar(idPersonagem);

            return StatusCode(204);
        }
    }
}
