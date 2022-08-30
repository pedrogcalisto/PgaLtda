using PGALtda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Helper
{
    public static class FuncionarioRepositoryTesteHelper
    {
        public static FuncionarioModel GerarFuncionarioModel()
        {
            return new FuncionarioModel
            {
                Ativo = true,
                Cpf = "12345678910",
                DtCriacao = new DateTime(),
                Id = 1,
                Idade = 20,
                JaVinculado = false,
                Nome = "Funcionario Teste"
            };
        }
    }
}
