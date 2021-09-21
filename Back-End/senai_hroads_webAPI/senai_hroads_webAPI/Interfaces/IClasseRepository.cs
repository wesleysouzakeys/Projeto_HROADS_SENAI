using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai_hroads_webAPI.Interfaces
{
    interface IClasseRepository
    {
        List<Classe> Listar();
        Classe BuscarPorId(int idClasse);
        void AtualizarIdUrl(int idClasse, Classe classeAtualizada);
        void Cadastrar(Classe novaClasse);
        void Deletar(int idClasse);
    }
}
