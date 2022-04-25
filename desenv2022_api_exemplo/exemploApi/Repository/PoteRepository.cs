using exemploApi.Context;
using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public class PoteRepository : IPoteRepository
    {
        private readonly AppDbContext _appDbContext;

        public PoteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //classe interagir com o banco de dados
        //como fazer

        public IEnumerable<Pote> ObterTodos()
        {
            return _appDbContext.Pote;

        }
    }
}
