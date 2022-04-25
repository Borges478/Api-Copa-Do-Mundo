using exemploApi.Context;
using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public class PaisesRepository : IPaisesRepository
    {
        private readonly AppDbContext _appDbContext;

        public PaisesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //classe interagir com o banco de dados
        //como fazer
        public void Adicionar(Paises paises)
        {
            _appDbContext.Paises.Add(paises);
            _appDbContext.SaveChanges();

        }

        public void Atualizar(Paises paises)
        {
            _appDbContext.Paises.Update(paises);
            _appDbContext.SaveChanges();

        }

        public Paises ObterPorId(int id)
        {
            return _appDbContext.Paises.Find(id);


        }

        public IEnumerable<Paises> ObterTodas()
        {
            return _appDbContext.Paises;
        }

        public void Remover(int id)
        {
            var entidadepais = ObterPorId(id);
            _appDbContext.Paises.Remove(entidadepais);
        }
    }
}