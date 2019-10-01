using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
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

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
