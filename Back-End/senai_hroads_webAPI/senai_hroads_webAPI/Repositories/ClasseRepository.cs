using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idClasse, Tipousuario classeAtualizada)
        {
            throw new NotImplementedException();
        }

        public Classe BuscarPorId(int idClasse)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Classe novaClasse)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idClasse)
        {
            throw new NotImplementedException();
        }

        public List<Classe> Listar()
        {
            return ctx.Classes.ToList<>
        }
    }
}
