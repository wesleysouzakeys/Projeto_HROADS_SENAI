using senai_hroads_webAPI.Contexts;
using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai_hroads_webAPI.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();
        Usuario BuscarPorId(int idUsuario);
        void AtualizarIdUrl(int idUsuario, Usuario usuarioAtualizado);
        void Cadastrar(Usuario novoUsuario);
        void Deletar(int idUsuario);
        Usuario Login(string email, string senha);
    }
}
