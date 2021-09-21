using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idHabilidade, Habilidade habilidadeAtualizada)
        {
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(idHabilidade);

            if (habilidadeAtualizada.IdTipoHabilidade != 0 && habilidadeAtualizada.NomeHabilidade != null)
            {
                habilidadeBuscada.IdTipoHabilidade = habilidadeAtualizada.IdTipoHabilidade;
                habilidadeBuscada.NomeHabilidade = habilidadeAtualizada.NomeHabilidade;
            }

            ctx.Habilidades.Update(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public Habilidade BuscarPorId(int idHabilidade)
        {
            return ctx.Habilidades.FirstOrDefault(h => h.IdHabilidade == idHabilidade);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Add(novaHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idHabilidade)
        {
            Habilidade habilidadeBuscada = ctx.Habilidades.Find(idHabilidade);

            ctx.Habilidades.Remove(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades.ToList();
        }
    }
}
