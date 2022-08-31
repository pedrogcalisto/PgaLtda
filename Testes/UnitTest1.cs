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
    [Collection(nameof(FuncionarioRepositoryCollection))]
    public class FuncionarioRepositoryTeste
    {
        private readonly FuncionarioRepositoryTesteFixture _funcionarioTesteFixture;
        private readonly FuncionarioRepository _funcionarioRepository;

        public FuncionarioRepositoryTeste(FuncionarioRepositoryTesteFixture funcionarioTesteFixture)
        {
            _funcionarioTesteFixture = funcionarioTesteFixture;
            _funcionarioRepository = _funcionarioTesteFixture.ObterFuncionarioRepository();
        }
        [Fact]
        public void Cadastrar()
        {
            _funcionarioTesteFixture.CriarCenario();
            var retorno = _funcionarioRepository.Cadastrar(FuncionarioRepositoryTesteHelper.GerarFuncionarioModel());
            retorno.Should().BeEquivalentTo(FuncionarioRepositoryTesteHelper.GerarFuncionarioModel());
        }
        [Fact]
        public void Cadastrar_JaExistente()
        {
            _funcionarioTesteFixture.CriarCenario_Cpf_Ja_Cadastrado();
            Assert.Throws<Exception>(() => _funcionarioRepository.Cadastrar(FuncionarioRepositoryTesteHelper.GerarFuncionarioModel()));
        }

    }
}