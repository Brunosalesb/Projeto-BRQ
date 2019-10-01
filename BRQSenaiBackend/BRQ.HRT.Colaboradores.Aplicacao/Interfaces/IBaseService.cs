using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(string userId, TEntity obj);

        TEntity GetById(string userId, string id);

        IEnumerable<TEntity> GetAll(string userId);

        void Update(string id, TEntity obj);

        void Remove(string id);
    }
}
