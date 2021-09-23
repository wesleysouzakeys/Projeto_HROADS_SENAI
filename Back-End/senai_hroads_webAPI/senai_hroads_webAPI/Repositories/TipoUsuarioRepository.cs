using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using senai_hroads_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webAPI.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void AtualizarIdUrl(int idTipoUsuario, Tipousuario tipoUsuarioAtualizado)
        {
            Tipousuario tipoUsuarioBuscado = ctx.Tipousuarios.Find(idTipoUsuario);

            if (tipoUsuarioAtualizado.TipoUsuario1 != null)
            {
                tipoUsuarioBuscado.TipoUsuario1 = tipoUsuarioAtualizado.TipoUsuario1;
            }

            ctx.Tipousuarios.Update(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public Tipousuario BuscarPorId(int idTipoUsuario)
        {
            return ctx.Tipousuarios.FirstOrDefault(t => t.IdTipoUsuario == idTipoUsuario);
        }

        public void Cadastrar(Tipousuario novoTipoUsuario)
        {
            ctx.Tipousuarios.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoUsuario)
        {
            Tipousuario tipoUsuarioBuscado = ctx.Tipousuarios.Find(idTipoUsuario);

            ctx.Tipousuarios.Remove(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Tipousuario> Listar()
        {
            return ctx.Tipousuarios.ToList();
        }
    }
}
