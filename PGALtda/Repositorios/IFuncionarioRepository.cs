using PGALtda.Models;
using System.Collections.Generic;

namespace PGALtda.Repositorios
{
    public interface IFuncionarioRepository
    {
        List<FuncionarioModel> Listar();
        FuncionarioModel Cadastrar(FuncionarioModel funcionario);
        bool Inativar(int id);
        FuncionarioModel Obter(int id);
        FuncionarioModel Lstar();
        IEnumerable<FuncionarioModel> ListarFuncionariosSemVinculo();
    }
}
