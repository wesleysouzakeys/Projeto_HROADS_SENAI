using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai_hroads_webAPI.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();
        Habilidade BuscarPorId(int idHabilidade);
        void AtualizarIdUrl(int idHabilidade, Habilidade habilidadeAtualizada);
        void Cadastrar(Habilidade novaHabilidade);
        void Deletar(int idHabilidade);
    }
}
