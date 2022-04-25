using exemploApi.Context;
using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public class ConfederecaoRepository : IConfederacaoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ConfederecaoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //classe interagir com o banco de dados
        //como fazer
        public void Adicionar(Confederacao confederacao)
        {
            _appDbContext.Confederacao.Add(confederacao);
            _appDbContext.SaveChanges();

        }

        public void Atualizar(Confederacao confederacao)
        {
            _appDbContext.Confederacao.Update(confederacao);
            _appDbContext.SaveChanges();

        }

        public Confederacao ObterPorId(int id)
        {
            return _appDbContext.Confederacao.Find(id);
            

        }

        public IEnumerable<Confederacao> ObterTodas()
        {
            return _appDbContext.Confederacao;
        }

        public void Remover(int id)
        {
            var entidade = ObterPorId(id);
            _appDbContext.Confederacao.Remove(entidade);
        }
    }
}
