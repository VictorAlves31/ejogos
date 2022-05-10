using System.Collections.Generic;
using EGames.Models;

namespace EGames.Interface
{
    public interface IEquipe
    {
        // Contrato
        // Representa os métodos que são obrigatórios em uma classe.

        void Criar(Equipe novaEquipe);

        List<Equipe> LerEquipes();

        void Editar(Equipe novaEquipe);

    }
}
