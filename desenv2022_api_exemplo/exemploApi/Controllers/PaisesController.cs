using exemploApi.Models;
using exemploApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exemploApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaisesController : Controller
    {
        private readonly IPaisesRepository _repository;

        [HttpGet]
        public IActionResult Teste()
        {
            return Ok();
        }

            public PaisesController(IPaisesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ObterTodas()
        {
           
            return Ok(_repository.ObterTodas());
        }
        [HttpGet]
        public IActionResult ObterPorId(int id)
        {
            _repository.ObterPorId(id);

            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Paises paises)
        {

            _repository.Adicionar(paises);


            return View();
        }

        [HttpPut]
        public IActionResult Atualizar(int id, Paises paises)
        {

            _repository.Atualizar(paises);

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

