using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_hroads_webAPI.Interfaces;
using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai_hroads_webAPI.Repositories;

namespace senai_hroads_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoHabilidadesController : ControllerBase
    {
        private ITiposHabilidadeRepository _tipoHabilidadeRepository { get; set; }

        public TipoHabilidadesController()
        {
            _tipoHabilidadeRepository = new TiposHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_tipoHabilidadeRepository.Listar());
        }

        [HttpGet("{idTipoHabilidade}")]
        public IActionResult BuscarPorId(int idTipoHabilidade)
        {
            return Ok(_tipoHabilidadeRepository.BuscarPorId(idTipoHabilidade));
        }

        [HttpPost]
        public IActionResult Cadastrar(Tipohabilidade novoTipoHabilidade)
        {
            _tipoHabilidadeRepository.Cadastrar(novoTipoHabilidade);

            return StatusCode(201);
        }

        [HttpPut("{idTipoHabilidade}")]
        public IActionResult Atualizar(int idTipoHabilidade, Tipohabilidade tipoHabilidadeAtualizada)
        {
            _tipoHabilidadeRepository.AtualizarIdUrl(idTipoHabilidade, tipoHabilidadeAtualizada);
            return StatusCode(204);
        }

        [HttpDelete("{idTipoHabilidade}")]
        public IActionResult Deletar(int idTipoHabilidade)
        {
            _tipoHabilidadeRepository.Deletar(idTipoHabilidade);

            return StatusCode(204);
        }
    }
}
