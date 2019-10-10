using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
       
        void Add(TEntity obj);

        TEntity GetById(int id);


        IEnumerable<TEntity> GetAll(int userId);
        IEnumerable<TEntity> GetAll();

        void Update(string id, TEntity obj);

        void Update(TEntity obj);

        void Remove(string id);
    }
}
