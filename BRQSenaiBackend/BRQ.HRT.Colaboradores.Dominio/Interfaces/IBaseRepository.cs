using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IQueryable<TEntity> GetAll();

        void Update(string id, TEntity obj);
        void Update(TEntity obj);

        void Remove(int id);
    }
}
