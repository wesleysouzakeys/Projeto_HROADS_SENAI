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
    public class HabilidadesController : ControllerBase
    {
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadesController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_habilidadeRepository.Listar());
        }

        [HttpGet("{idHabilidade}")]
        public IActionResult BuscarPorId(int idHabilidade)
        {
            return Ok(_habilidadeRepository.BuscarPorId(idHabilidade));
        }

        [HttpPost]
        public IActionResult Cadastrar(Habilidade novaHabilidade)
        {
            _habilidadeRepository.Cadastrar(novaHabilidade);

            return StatusCode(201);
        }

        [HttpPut("{idHabilidade}")]
        public IActionResult Atualizar(int idHabilidade, Habilidade habilidadeAtualizada)
        {
            _habilidadeRepository.AtualizarIdUrl(idHabilidade, habilidadeAtualizada);
            return StatusCode(204);
        }

        [HttpDelete("{idHabilidade}")]
        public IActionResult Deletar(int idHabilidade)
        {
            _habilidadeRepository.Deletar(idHabilidade);

            return StatusCode(204);
        }
    }
}
