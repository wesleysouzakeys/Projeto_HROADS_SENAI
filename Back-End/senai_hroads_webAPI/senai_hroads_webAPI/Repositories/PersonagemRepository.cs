using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idPersonagem, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = ctx.Personagens.Find(idPersonagem);
            DateTime dataNula = Convert.ToDateTime("01/01/0001");

            if (personagemBuscado.IdClasseHabi != 0 && personagemBuscado.NomePersonagem != null 
                && personagemBuscado.QtdMaxVida != 0 && personagemBuscado.QtdMaxMana != 0 
                && personagemBuscado.DataAtualizacao != dataNula 
                && personagemBuscado.DataCriacao != dataNula)
            {
                personagemBuscado.IdClasseHabi = personagemAtualizado.IdClasseHabi;
                personagemBuscado.NomePersonagem = personagemAtualizado.NomePersonagem;
                personagemBuscado.QtdMaxVida = personagemAtualizado.QtdMaxVida;
                personagemBuscado.QtdMaxMana = personagemAtualizado.QtdMaxMana;
                personagemBuscado.DataAtualizacao = personagemAtualizado.DataAtualizacao;
                personagemBuscado.DataCriacao = personagemAtualizado.DataCriacao;
            }

            ctx.Personagens.Update(personagemBuscado);

            ctx.SaveChanges();
        }

        public Personagem BuscarPorId(int idPersonagem)
        {
            return ctx.Personagens.FirstOrDefault(p => p.IdPersonagem == idPersonagem);
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            ctx.Personagens.Add(novoPersonagem);

            ctx.SaveChanges();
        }

        public void Deletar(int idPersonagem)
        {
            Personagem personagemBuscado = ctx.Personagens.Find(idPersonagem);

            ctx.Personagens.Remove(personagemBuscado);

            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagens.ToList();
        }
    }
}
