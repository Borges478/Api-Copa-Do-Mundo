using exemploApi.Context;
using exemploApi.Models;
using System.Collections.Generic;

namespace exemploApi.Repository
{
    public class GruposRepository : IGruposRepository
    {
        private readonly AppDbContext _appDbContext;

        public GruposRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //classe interagir com o banco de dados
        //como fazer
        public void Adicionar(Grupo grupo)
        {
            _appDbContext.Grupo.Add(grupo);
            _appDbContext.SaveChanges();

        }

        public void Atualizar(Grupo grupo)
        {
            _appDbContext.Grupo.Update(grupo);
            _appDbContext.SaveChanges();

        }

        public Grupo ObterPorId(int id)
        {
            return _appDbContext.Grupo.Find(id);


        }

        public IEnumerable<Grupo> ObterTodas()
        {
            return _appDbContext.Grupo;
        }

        public void Remover(int id)
        {
            var entidadegrupo = ObterPorId(id);
            _appDbContext.Grupo.Remove(entidadegrupo);
        }

       
        
            
        }
    }
