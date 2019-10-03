using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(string userId, TEntity obj);
        void Add(TEntity obj);

        TEntity GetById(string userId, string id);
        TEntity GetById(string id);


        IEnumerable<TEntity> GetAll(string userId);
        IEnumerable<TEntity> GetAll();

        void Update(string id, TEntity obj);

        void Update(TEntity obj);

        void Remove(string id);
    }
}
