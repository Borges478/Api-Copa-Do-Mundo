using exemploApi.Context;
using exemploApi.Models;
using exemploApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exemploApi.Controllers
{
    public class ConfederacaoController : Controller
    {
        private readonly IConfederacaoRepository _repository;

        public ConfederacaoController(IConfederacaoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ObterTodas(Confederacao confederacao)

        {

            return View(confederacao);
        }

        [HttpGet]
        public IActionResult ObterPorId(int id)
        {
            _repository.ObterPorId(id);
        
        return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Confederacao confederacao)
        {

            _repository.Adicionar(confederacao);


            return View();
        }

        [HttpPut]
        public IActionResult Atualizar(int id, Confederacao confederacao)
        {

            _repository.Atualizar(confederacao);
            
            return View();
        }

        [HttpDelete]
        public IActionResult Remover(int id)
        {
            _repository.Remover(id);
            
            return View();
        }
    }
}
