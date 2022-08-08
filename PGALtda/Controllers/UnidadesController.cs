using Microsoft.AspNetCore.Mvc;
using PGALtda.Models;
using PGALtda.Repositorios;

namespace PGALtda.Controllers
{
    public class UnidadesController : Controller
    {
        private readonly IUnidadeRepository _unidadeRepository;

        public UnidadesController (IUnidadeRepository unidadeRepository)
        {
            _unidadeRepository = unidadeRepository;
        }

        public IActionResult Index()
        {
            var unidades = _unidadeRepository.Listar();
            return View(unidades);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult InativarConfirmacao(int id)
        {
            var unidade = _unidadeRepository.Obter(id);
            return View(unidade);
        }
        [HttpPost]
        public IActionResult Cadastrar(UnidadeModel unidade) 
        {
            if (ModelState.IsValid)
            {
                _unidadeRepository.Cadastrar(unidade);
                return RedirectToAction("Index");
            }

            return View(unidade);
        }
        public IActionResult Inativar(int id)
        {
            _unidadeRepository.Inativar(id);
            return RedirectToAction("Index");
        }
    }
}
