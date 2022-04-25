using exemploApi.Context;
using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public class ParticipantesRepository : IParticipantesGrupoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ParticipantesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //classe interagir com o banco de dados
        //como fazer
        public void Adicionar(ParticipantesGrupo participantes)
        {
            _appDbContext.ParticipantesGrupo.Add(participantes);
            _appDbContext.SaveChanges();

        }

        public void Atualizar(ParticipantesGrupo participantes)
        {
            _appDbContext.ParticipantesGrupo.Update(participantes);
            _appDbContext.SaveChanges();

        }

        public ParticipantesGrupo ObterPorId(int id)
        {
            return _appDbContext.ParticipantesGrupo.Find(id);


        }

        public IEnumerable<ParticipantesGrupo> ObterTodas()
        {
            return _appDbContext.ParticipantesGrupo;
        }

        public void Remover(int id)
        {
            var entidade = ObterPorId(id);
            _appDbContext.ParticipantesGrupo.Remove(entidade);
        }
    }

   
}
