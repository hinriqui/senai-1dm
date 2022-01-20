using System.Collections.Generic;
using EPlayersMVC.Models;

namespace EPlayersMVC.Interfaces
{
    public interface IJogador
    {
         void Criar(Jogador j);

         List<Jogador> LerTudo();

         void Alterar(Jogador j);
         void Deletar(int id);

    }
}