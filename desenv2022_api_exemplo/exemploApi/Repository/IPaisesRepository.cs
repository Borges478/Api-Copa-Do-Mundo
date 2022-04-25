using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public interface IPaisesRepository
    {
    public IEnumerable<Paises> ObterTodas();

        public Paises ObterPorId(int id);
        public void Adicionar(Paises paises);
        public void Atualizar(Paises paises);

        public void Remover(int id);
    
    
    
    }
}
