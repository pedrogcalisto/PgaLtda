using Microsoft.AspNetCore.Mvc;
using PGALtda.Models.DTOs;
using PGALtda.Repositorios.Interface;
using System;

namespace PGALtda.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly IRelatorioRepository _relatorioRepository;

        public RelatorioController(IRelatorioRepository relatorioRepository)
        {
            _relatorioRepository = relatorioRepository;
        }
        public IActionResult GerarRelatorio(FiltroDto filtro)
        {
            var dados =  _relatorioRepository.ObterDados(filtro);
            return Ok(dados);
        }
    }
}
