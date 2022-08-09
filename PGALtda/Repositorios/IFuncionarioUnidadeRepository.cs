using PGALtda.Models;
using System.Collections.Generic;

namespace PGALtda.Repositorios
{
    public interface IFuncionarioUnidadeRepository
    {
        FuncionarioUnidadeModel Vincular(FuncionarioUnidadeModel model);
        void DemitirFuncionario(int idFuncionario);
        IEnumerable<FuncionarioUnidadeModel> Listar();
        VincularFuncionarioModel Obter(int idFuncionario);
    }
}
