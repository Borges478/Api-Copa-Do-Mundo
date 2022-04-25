using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public interface IParticipantesGrupoRepository
    {
        //O que fazer 
        public IEnumerable<ParticipantesGrupo> ObterTodas();

        public ParticipantesGrupo ObterPorId(int id);
        public void Adicionar(ParticipantesGrupo participantes);
        public void Atualizar(ParticipantesGrupo participantes);

        public void Remover(int id);


    }
}