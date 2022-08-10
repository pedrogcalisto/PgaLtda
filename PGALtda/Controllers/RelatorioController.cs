using Microsoft.AspNetCore.Mvc;
using PGALtda.Models.DTOs;
using PGALtda.Repositorios;
using PGALtda.Repositorios.Interface;
using System;

namespace PGALtda.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly IRelatorioRepository _relatorioRepository;
        private readonly IUnidadeRepository _unidadeRepository;

        public RelatorioController(IRelatorioRepository relatorioRepository, IUnidadeRepository unidadeRepository)
        {
            _relatorioRepository = relatorioRepository;
            _unidadeRepository = unidadeRepository;
        }
        public IActionResult Index()
        {
            FiltroDto filtroDto = new FiltroDto();
            filtroDto.Unidades = _unidadeRepository.Listar();
            return View("Index", filtroDto);
        }
        [HttpPost]
        public IActionResult GerarRelatorio(FiltroDto filtro)
        {
            var dados =  _relatorioRepository.ObterDados(filtro);
            return View("Relatorio",dados);
        }
    }
}
