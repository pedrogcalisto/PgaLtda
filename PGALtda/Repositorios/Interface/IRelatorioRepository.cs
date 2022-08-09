using PGALtda.Models;
using PGALtda.Models.DTOs;
using System.Collections.Generic;

namespace PGALtda.Repositorios.Interface
{
    public interface IRelatorioRepository
    {
        List<FuncionarioUnidadeModel> ObterDados(FiltroDto filtro);
    }
}
