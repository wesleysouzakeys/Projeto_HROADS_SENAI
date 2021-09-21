using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class ClasseHabilidadeRepository : IClasseHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idClasseHabilidade, Classehabilidade classeHabilidadeAtualizada)
        {
            Classehabilidade classeBuscada = ctx.Classehabilidades.Find(idClasseHabilidade);

            if (classeHabilidadeAtualizada.IdClasse != 0 && classeHabilidadeAtualizada.IdHabilidade != 0)
            {
                classeBuscada.IdClasse = classeHabilidadeAtualizada.IdClasse;
                classeBuscada.IdHabilidade = classeHabilidadeAtualizada.IdHabilidade;
            }

            ctx.Classehabilidades.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public Classehabilidade BuscarPorId(int idClasseHabilidade)
        {
            return ctx.Classehabilidades.FirstOrDefault(e => e.IdClasseHabi == idClasseHabilidade);
        }

        public void Cadastrar(Classehabilidade novaClasseHabilidade)
        {
            ctx.Classehabilidades.Add(novaClasseHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idClasseHabilidade)
        {
            Classehabilidade classehabilidade = ctx.Classehabilidades.Find(idClasseHabilidade);

            ctx.Classehabilidades.Remove(classehabilidade);

            ctx.SaveChanges();
        }

        public List<Classehabilidade> Listar()
        {
            return ctx.Classehabilidades.ToList();
        }
    }
}
