using exemploApi.Context;
using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public class PotePaisRepository : IPotePaisRepository
    {
        private readonly AppDbContext _appDbContext;

        public PotePaisRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //classe interagir com o banco de dados
        //como fazer
        
        public IEnumerable<PotePais> ObterTodos()
        {
            return _appDbContext.PotePais;

        }


        public PotePais BuscarTodosParticipantes(int IdPote)
        {
           return _appDbContext.PotePais.Find(IdPote);
         }

        public PotePais BuscarParticipantes(int IdParticipantes, int idPote)
        {
            return _appDbContext.PotePais.Find(IdParticipantes,idPote);



        }

        
        public void RemoverParticipantes(int idParticipante, int idPote)
        {
            var Participantes = BuscarParticipantes(idParticipante,idPote);
            _appDbContext.Confederacao.Remove(Participantes);
        }

       
    }
}
