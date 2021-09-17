using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai_hroads_webAPI.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<Tipousuario> Listar();
        Tipousuario BuscarPorId(int idTipoUsuario);
        void AtualizarIdUrl(int idTipoUsuario, Tipousuario tipoUsuarioAtualizado);
        void Cadastrar(Tipousuario novoTipoUsuario);
        void Deletar(int idTipoUsuario);

    }
}
