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
    [CollectionDefinition(nameof(RelatorioRepositoryCollection))]
    public class RelatorioRepositoryCollection : ICollectionFixture<RelatorioRepositoryTesteFixture> { }
    public class RelatorioRepositoryTesteFixture : IDisposable
    {
        public readonly AutoMocker Mocker = new();

        public void Dispose()
        {
        }

        public RelatorioRepository ObterRelatorioRepository()
        {
            return Mocker.CreateInstance<RelatorioRepository>();
        }
        public void CriarCenario()
        {
        }
        public void CriarCenario_Cpf_Ja_Cadastrado()
        {
        }
    }
}
