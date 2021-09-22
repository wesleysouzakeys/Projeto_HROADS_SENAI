using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class TiposHabilidadeRepository : ITiposHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idTipoHabilidade, Tipohabilidade tipoHabilidadeAtualizado)
        {
            Tipohabilidade tipoHabilidadeBuscado = ctx.Tipohabilidades.Find(idTipoHabilidade);

            if (tipoHabilidadeBuscado.TipoHabilidade1 != null && tipoHabilidadeBuscado.Valor != 0)
            {
                tipoHabilidadeBuscado.TipoHabilidade1 = tipoHabilidadeAtualizado.TipoHabilidade1;
                tipoHabilidadeBuscado.Valor = tipoHabilidadeAtualizado.Valor;
            }

            ctx.Tipohabilidades.Update(tipoHabilidadeBuscado);

            ctx.SaveChanges();
        }

        public Tipohabilidade BuscarPorId(int idTipoHabilidade)
        {
            return ctx.Tipohabilidades.FirstOrDefault(t => t.IdTipoHabilidade == idTipoHabilidade);
        }

        public void Cadastrar(Tipohabilidade novoTipoHabilidade)
        {
            ctx.Tipohabilidades.Add(novoTipoHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoHabilidade)
        {
            Tipohabilidade tipoHabilidadeBuscado = ctx.Tipohabilidades.Find(idTipoHabilidade);

            ctx.Tipohabilidades.Remove(tipoHabilidadeBuscado);

            ctx.SaveChanges();
        }

        public List<Tipohabilidade> Listar()
        {
            return ctx.Tipohabilidades.ToList();
        }
    }
}
