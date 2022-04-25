using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public interface IGruposRepository
    {
        public IEnumerable<Grupo> ObterTodas();

        public Grupo ObterPorId(int id);
        public void Adicionar(Grupo grupo);
        public void Atualizar(Grupo grupo);

        public void Remover(int id);



    }
}
