using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai_hroads_webAPI.Interfaces
{
    interface ITiposHabilidadeRepository
    {
        List<Tipohabilidade> Listar();
        Tipohabilidade BuscarPorId(int idTipoHabilidade);
        void AtualizarIdUrl(int idTipoHabilidade, Tipohabilidade tipoHabilidadeAtualizado);
        void Cadastrar(Tipohabilidade novoTipoHabilidade);
        void Deletar(int idTipoHabilidade);
    }
}
