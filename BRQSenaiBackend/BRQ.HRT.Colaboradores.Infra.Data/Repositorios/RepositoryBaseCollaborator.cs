using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public abstract class RepositoryBaseCollaborator<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ContextoColaboradores _dbContext;

        protected RepositoryBaseCollaborator(ContextoColaboradores dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity obj)
        {
            _dbContext.Set<TEntity>().Add(obj);
            _dbContext.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public TEntity GetById(string id)
        {
            TEntity itemBuscado = _dbContext.Set<TEntity>().Find(id);
            return itemBuscado;
        }

        public void Remove(string id)
        {
            var entity = GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(string id, TEntity obj)
        {
            _dbContext.Set<TEntity>().Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
