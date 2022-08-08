using Microsoft.AspNetCore.Mvc;
using PGALtda.Models;
using PGALtda.Repositorios;

namespace PGALtda.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public IActionResult Index()
        {
            var funcionarios = _funcionarioRepository.Listar();
            return View(funcionarios);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult InativarConfirmacao(int id)
        {
            var funcionario = _funcionarioRepository.Obter(id);
            return View(funcionario);
        }
        [HttpPost]
        public IActionResult Cadastrar(FuncionarioModel funcionario)
        {
            if (ModelState.IsValid)
            {
                _funcionarioRepository.Cadastrar(funcionario);
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }
        public IActionResult Inativar(int id)
        {
            _funcionarioRepository.Inativar(id);
            return RedirectToAction("Index");
        }
    }
}
