using PGALtda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Helper
{
    public static class UnidadeRepositoryTesteHelper
    {
        public static UnidadeModel GerarUnidadeModel()
        {
            return new UnidadeModel
            {
                Ativo = true,
                Cnpj = "12345678910234",
                DtCriacao = new DateTime(),
                Id = 1,
                Nome = "Unidade Teste",
                Cidade = "Lavras"
            };
        }

        public static List<UnidadeModel> GerarListaUnidadeModel()
        {
            var listaUni = new List<UnidadeModel>();
            var uni1 = new UnidadeModel
            {
                Ativo = true,
                Cnpj = "12345678910234",
                DtCriacao = new DateTime(),
                Id = 1,
                Nome = "Unidade Teste",
                Cidade = "Lavras"
            };
            listaUni.Add(uni1);

            var uni2= new UnidadeModel
            {
                Ativo = true,
                Cnpj = "12345678910235",
                DtCriacao = new DateTime(),
                Id = 1,
                Nome = "Unidade Teste2",
                Cidade = "Lavras"
            };
            listaUni.Add(uni2);

            return listaUni.ToList();
        }

        public static UnidadeModel GerarLstaUnidadeModel()
        {
            return new UnidadeModel
            {
                Ativo = true,
                Cnpj = "12345678910235",
                DtCriacao = new DateTime(),
                Id = 1,
                Nome = "Unidade Teste2",
                Cidade = "Lavras"
            };
        }
    }
}
