using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai_hroads_webAPI.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();
        Tipousuario BuscarPorId(int idUsuario);
        void AtualizarIdUrl(int idUsuario, Usuario usuarioAtualizado);
        void Cadastrar(Tipousuario novoUsuario);
        void Deletar(int idUsuario);
        Usuario Login(string email, string senha);
    }
}
