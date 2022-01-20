using System.Collections.Generic;
using EPlayersMVC.Models;

namespace EPlayersMVC.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe e);
        List<Equipe> LerTudo();
        void Alterar(Equipe e);
        void Deletar(int idEquipe);
    }
}