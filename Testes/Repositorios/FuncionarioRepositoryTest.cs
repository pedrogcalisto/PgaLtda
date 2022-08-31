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
        public void Obter()
        {
            _funcionarioTesteFixture.CriarCenario_Editar();
            var retorno = _funcionarioRepository.Obter(1);
            retorno.Should().BeEquivalentTo(FuncionarioRepositoryTesteHelper.GerarFuncionarioModel());
        }

        [Fact]
        public void Inativar()
        {
            _funcionarioTesteFixture.CriarCenario_Inativar();
            var retorno = _funcionarioRepository.Inativar(It.IsAny<int>());
            retorno.Should().BeTrue();
        }

        [Fact]
        public void Listar() 
        {
            _funcionarioTesteFixture.CriarCenario_Lsta();
            var retorno = _funcionarioRepository.Lstar();
            retorno.Should().BeEquivalentTo(FuncionarioRepositoryTesteHelper.GerarLstaFuncionarioModel());
        }

    }
}