using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public interface IPoteRepository
    {
        public IEnumerable<Pote> ObterTodos(int idPote);



    }
}
