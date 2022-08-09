using Microsoft.AspNetCore.Mvc;
using PGALtda.Models;
using PGALtda.Repositorios;
using System.Linq;

namespace PGALtda.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IUnidadeRepository _unidadeRepository;
        private readonly IFuncionarioUnidadeRepository _funcionarioUnidadeRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository, IUnidadeRepository unidadeRepository, IFuncionarioUnidadeRepository funcionarioUnidadeRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _unidadeRepository = unidadeRepository;
           _funcionarioUnidadeRepository = funcionarioUnidadeRepository;    
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

        public IActionResult VincularFuncionario(int id)
        {
            VincularFuncionarioModel funcionarioUnidade = new VincularFuncionarioModel();
            funcionarioUnidade.Unidades = _unidadeRepository.Listar();
            var funcionario = _funcionarioRepository.Obter(id);
            funcionarioUnidade.FuncionarioId = funcionario.Id;
            funcionarioUnidade.FuncionarioNome = funcionario.Nome;
            return View("FuncionarioUnidade",funcionarioUnidade);
        }

        [HttpPost]
        public IActionResult VincularFuncionario(VincularFuncionarioModel vincularFuncionarios)
        {
            FuncionarioUnidadeModel funcionarioUnidade = new FuncionarioUnidadeModel();
            funcionarioUnidade.FuncionarioId = vincularFuncionarios.FuncionarioId;
            funcionarioUnidade.UnidadeId = vincularFuncionarios.UnidadeId;
            _funcionarioUnidadeRepository.Vincular(funcionarioUnidade);

            return RedirectToAction("Index");
        }

        public IActionResult DesvincularFuncionarioConfirmacao(int id)
        {
            var funcionario = _funcionarioUnidadeRepository.Obter(id);
            return View(funcionario);
        }

        public IActionResult DesvincularFuncionario(int id)
        {
            _funcionarioUnidadeRepository.DemitirFuncionario(id);
            return RedirectToAction("Index");
        }
    }
}
