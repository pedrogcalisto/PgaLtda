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

        public static List<FuncionarioModel> GerarListaFuncionarioModel()
        {
            var listaFunc = new List<FuncionarioModel>();
            var func1 = new FuncionarioModel
            {
                Ativo = true,
                Cpf = "12345678910",
                DtCriacao = new DateTime(),
                Id = 1,
                Idade = 20,
                JaVinculado = false,
                Nome = "Funcionario Teste"
            };
            listaFunc.Add(func1);

            var func2 = new FuncionarioModel
            {
                Ativo = true,
                Cpf = "12345678911",
                DtCriacao = new DateTime(),
                Id = 2,
                Idade = 20,
                JaVinculado = false,
                Nome = "Funcionario Teste 2"
            };
            listaFunc.Add(func2);

            return listaFunc.ToList();
        }

        public static FuncionarioModel GerarLstaFuncionarioModel()
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
