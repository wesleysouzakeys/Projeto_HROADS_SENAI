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
    public class ClassesHabilidadesController : ControllerBase
    {
        private IClasseHabilidadeRepository _classeHabilidadeRepository { get; set; }

        public ClassesHabilidadesController()
        {
            _classeHabilidadeRepository = new ClasseHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_classeHabilidadeRepository.Listar());
        }

        [HttpGet("{idClasseHabilidade}")]
        public IActionResult BuscarPorId(int idClasseHabi)
        {
            return Ok(_classeHabilidadeRepository.BuscarPorId(idClasseHabi));
        }

        [HttpPost]
        public IActionResult Cadastrar(Classehabilidade classeHabilidade)
        {
            _classeHabilidadeRepository.Cadastrar(classeHabilidade);

            return StatusCode(201);
        }

        [HttpPut("{idClasseHabilidade}")]
        public IActionResult Atualizar(int idClasseHabi, Classehabilidade classehabilidade)
        {
            _classeHabilidadeRepository.AtualizarIdUrl(idClasseHabi, classehabilidade);

            return StatusCode(204);
        }

        [HttpDelete("{idClasseHabilidade}")]
        public IActionResult Deletar(int idClasseHabi)
        {
            _classeHabilidadeRepository.Deletar(idClasseHabi);

            return StatusCode(204);
        }
    }
}
