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
    [CollectionDefinition(nameof(UnidadeRepositoryCollection))]
    public class UnidadeRepositoryCollection : ICollectionFixture<UnidadeRepositoryTesteFixture> { }
    public class UnidadeRepositoryTesteFixture : IDisposable
    {
        public readonly AutoMocker Mocker = new();

        public void Dispose()
        {
        }

        public UnidadeRepository ObterUnidadeRepository()
        {
            return Mocker.CreateInstance<UnidadeRepository>();
        }
        public void CriarCenario()
        {

            Mocker.GetMock<IBancoContext>()
                  .Setup(rep => rep.Unidades.Find(It.IsAny<object>())
              ).Returns<UnidadeModel>(null);

        }
        public void CriarCenario_Listar()
        {

            Mocker.GetMock<IBancoContext>()
                  .Setup(rep => rep.Unidades.ToList()
              ).Returns(UnidadeRepositoryTesteHelper.GerarListaUnidadeModel());

        }
        public void CriarCenario_Editar()
        {

            Mocker.GetMock<IBancoContext>()
                  .Setup(rep => rep.Unidades.Find(It.IsAny<int>())
              ).Returns(UnidadeRepositoryTesteHelper.GerarUnidadeModel());

        }

        public void CriarCenario_Inativar()
        {

            Mocker.GetMock<IBancoContext>()
                  .Setup(rep => rep.Unidades.Find(It.IsAny<int>())
              ).Returns(UnidadeRepositoryTesteHelper.GerarUnidadeModel());

        }

        public void CriarCenario_Lsta()
        {

            Mocker.GetMock<IBancoContext>()
                  .Setup(rep => rep.Unidades.Find()
              ).Returns(UnidadeRepositoryTesteHelper.GerarLstaUnidadeModel());
        }
    }
}
