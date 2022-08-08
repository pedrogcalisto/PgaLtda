using PGALtda.Models;
using System.Collections.Generic;

namespace PGALtda.Repositorios
{
    public interface IUnidadeRepository 
    {
        IEnumerable<UnidadeModel> Listar();
        UnidadeModel Cadastrar (UnidadeModel unidade);
        void Inativar(int id);
        UnidadeModel Obter(int id);
    }
}
