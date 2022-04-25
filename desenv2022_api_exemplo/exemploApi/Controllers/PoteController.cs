using exemploApi.Context;
using exemploApi.Models;
using exemploApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exemploApi.Controllers
{
    public class PoteController : Controller
    {
        private readonly IPoteRepository _repository;

        public PoteController(IPotePaisRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ObterTodosOsPotes(Pote pote )

        {

            return View(pote);
        }

        [HttpGet]
        public IActionResult BuscarTodosParticipantes(int idPote)
        {
            _repository.ObterTodos(idPote);

            return View();
        }

       

       [HttpDelete]
        public IActionResult RemoverParticipante(int idParticipante ,int idPote)
        {

            var Participantes = BuscarTodosParticipantes(idParticipante, idPote);
            AppDbContext.Confederacao.Remove(Participantes);

            return View();
        }
    }
}
