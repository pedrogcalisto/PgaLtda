using Moq;
using PGALtda.Data;
using PGALtda.Repositorios;
using Testes.Helper;
using Testes.TesteFixture;
using Xunit;
using FluentAssertions;
using System;

namespace Testes
{
    [Collection(nameof(UnidadeRepositoryCollection))]
    public class RelatorioRepositoryTeste
    {
        private readonly RelatorioRepositoryTesteFixture _relatorioTesteFixture;
        private readonly RelatorioRepository _funcionarioRepository;

        public RelatorioRepositoryTeste(RelatorioRepositoryTesteFixture relatorioTesteFixture)
        {
            _relatorioTesteFixture = relatorioTesteFixture;
            _funcionarioRepository = relatorioTesteFixture.ObterRelatorioRepository();
        }
        [Fact]
        public void Cadastrar()
        {
        }
        [Fact]
        public void Cadastrar_JaExistente()
        {
        }

    }
}