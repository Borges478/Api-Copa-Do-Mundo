using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public interface IConfederacaoRepository
    {
        //O que fazer 
        public IEnumerable<Confederacao> ObterTodas();

        public Confederacao ObterPorId(int id);
        public void Adicionar(Confederacao confederacao);
        public void Atualizar(Confederacao confederacao);

        public void Remover(int id);


    }
}
