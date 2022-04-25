using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public interface IPotePaisRepository
    {
        //O que fazer 
        public IEnumerable<PotePais> ObterTodos();

        public PotePais BuscarTodosParticipantes(int idPote);
        public void BuscarParticipantes(int idParticipante, int idPote);
        public void RemoverParticipante(int idParticipante, int idPote);


       


    }
}