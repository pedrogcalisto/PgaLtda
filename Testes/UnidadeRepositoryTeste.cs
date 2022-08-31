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
    public class UnidadeRepositoryTeste
    {
        private readonly UnidadeRepositoryTesteFixture _unidadeTesteFixture;
        private readonly UnidadeRepository _funcionarioRepository;

        public UnidadeRepositoryTeste(UnidadeRepositoryTesteFixture unidadeTesteFixture)
        {
            _unidadeTesteFixture = unidadeTesteFixture;
            _funcionarioRepository = unidadeTesteFixture.ObterUnidadeRepository();
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