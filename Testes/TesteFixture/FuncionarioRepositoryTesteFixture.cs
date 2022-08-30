using PGALtda.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Moq.AutoMock;
using PGALtda.Models;
using Testes.Helper;
using Microsoft.EntityFrameworkCore;
using PGALtda.Data;
using System.Linq.Expressions;

namespace Testes.TesteFixture
{
    [CollectionDefinition(nameof(FuncionarioRepositoryCollection))]
    public class FuncionarioRepositoryCollection : ICollectionFixture<FuncionarioRepositoryTesteFixture> { }
    public class FuncionarioRepositoryTesteFixture : IDisposable
    {
        public readonly AutoMocker Mocker = new();

        public void Dispose()
        {
        }

        public FuncionarioRepository ObterFuncionarioRepository()
        {
            return Mocker.CreateInstance<FuncionarioRepository>();
         }
        public void CriarCenario()
        {

            Mocker.GetMock<IBancoContext>()
                  .Setup(rep => rep.Funcionarios.Find(It.IsAny<object>())
              ).Returns<FuncionarioModel>(null);         

        }
        public void CriarCenario_Cpf_Ja_Cadastrado()
        {

            Mocker.GetMock<IBancoContext>()
                  .Setup(rep => rep.Funcionarios.Find(It.IsAny<object>())
              ).Returns(FuncionarioRepositoryTesteHelper.GerarFuncionarioModel());



        }
    }
}
