using PGALtda.Models;
using System.Collections.Generic;

namespace PGALtda.Repositorios
{
    public interface IFuncionarioRepository
    {
        IEnumerable<FuncionarioModel> Listar();
        FuncionarioModel Cadastrar(FuncionarioModel funcionario);
        void Inativar(int id);
        FuncionarioModel Obter(int id);
        IEnumerable<FuncionarioModel> ListarFuncionariosSemVinculo();
    }
}
