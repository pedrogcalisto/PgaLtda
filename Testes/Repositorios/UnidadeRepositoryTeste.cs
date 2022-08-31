using Moq;
using PGALtda.Data;
using PGALtda.Repositorios;
using Testes.Helper;
using Testes.TesteFixture;
using Xunit;
using FluentAssertions;
using System;

namespace Testes.Repositorios
{
    [Collection(nameof(UnidadeRepositoryCollection))]
    public class UnidadeRepositoryTeste
    {
        private readonly UnidadeRepositoryTesteFixture _unidadeTesteFixture;
        private readonly UnidadeRepository _unidadeRepository;

        public UnidadeRepositoryTeste(UnidadeRepositoryTesteFixture unidadeTesteFixture)
        {
            _unidadeTesteFixture = unidadeTesteFixture;
            _unidadeRepository = unidadeTesteFixture.ObterUnidadeRepository();
        }
        [Fact]
        public void Cadastrar()
        {
            _unidadeTesteFixture.CriarCenario();
            var retorno = _unidadeRepository.Cadastrar(UnidadeRepositoryTesteHelper.GerarUnidadeModel());
            retorno.Should().BeEquivalentTo(UnidadeRepositoryTesteHelper.GerarUnidadeModel());
        }
        [Fact]
        public void Obter()
        {
            _unidadeTesteFixture.CriarCenario_Editar();
            var retorno = _unidadeRepository.Obter(1);
            retorno.Should().BeEquivalentTo(UnidadeRepositoryTesteHelper.GerarUnidadeModel());
        }

        [Fact]
        public void Inativar()
        {
            _unidadeTesteFixture.CriarCenario_Inativar();
            var retorno = _unidadeRepository.Inativar(It.IsAny<int>());
            retorno.Should().BeTrue();
        }

        [Fact]
        public void Listar()
        {
            _unidadeTesteFixture.CriarCenario_Lsta();
            var retorno = _unidadeRepository.Lstar();
            retorno.Should().BeEquivalentTo(UnidadeRepositoryTesteHelper.GerarLstaUnidadeModel());
        }

    }
}