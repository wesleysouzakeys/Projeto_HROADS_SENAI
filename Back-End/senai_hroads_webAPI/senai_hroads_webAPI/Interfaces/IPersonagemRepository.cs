using senai_hroads_webAPI.Domains;
using System;
using System.Collections.Generic;

namespace senai_hroads_webAPI.Interfaces
{
    interface IPersonagemRepository
    {
        List<Personagem> Listar();
        Personagem BuscarPorId(int idPersonagem);
        void AtualizarIdUrl(int idPersonagem, Personagem personagemAtualizado);
        void Cadastrar(Personagem novoPersonagem);
        void Deletar(int idPersonagem);
    }
}
