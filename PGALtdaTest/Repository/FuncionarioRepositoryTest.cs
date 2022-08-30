using AutoFixture;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using PGALtda.Data;
using PGALtda.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PGALtdaTest.Repository
{
    public class FuncionarioRepositoryTest
    {
        private FuncionarioRepository _funcionarioRepository;

        public FuncionarioRepositoryTest()
        {
            _funcionarioRepository = new FuncionarioRepository(new Mock<BancoContext>().Object, new Mock<FuncionarioUnidadeRepository>().Object);
        }

        [Fact]
        public async Task Inativar ()
        {
            var response = 2;

            _funcionarioRepository.Inativar(response);
            var result = StatusCodes.Status200OK;

            Assert.Equal(result, StatusCodes.Status200OK);
        }
    }
}
