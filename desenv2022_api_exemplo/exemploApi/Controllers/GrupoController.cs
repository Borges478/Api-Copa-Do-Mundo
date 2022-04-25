using exemploApi.Context;
using exemploApi.Models;
using exemploApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exemploApi.Controllers
{
    public class GrupoController : Controller
    {
        private readonly IGruposRepository _repository;
       private readonly ParticipantesRepository participanteRepository; 

        public GrupoController(IGruposRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ObterTodos(Grupo grupo)

        {

            return Ok(grupo);
        }

        [HttpGet]
        public IActionResult ObterPorId(int id)
        {
            _repository.ObterPorId(id);

            return Ok(id);
        }

        [HttpPost]
        public IActionResult Adicionar(Grupo grupo)
        {

            _repository.Adicionar(grupo);


            return Ok(grupo);
        }

        
        [HttpPost]
        [Route("AdicionarParticipante")]
        public IActionResult AdicionarParticipante(ParticipantesGrupo participante)
        {

           _repository.Adicionar(participante);


          return Ok(participante);
        }

        [HttpPut]
        public IActionResult Atualizar(int id, Grupo grupo)
        {

            _repository.Atualizar(grupo);

            return Ok(grupo);
        }

        [HttpDelete]
        public IActionResult Remover(int id)
        {
            _repository.Remover(id);

            return Ok(id);
        }
    }
}
