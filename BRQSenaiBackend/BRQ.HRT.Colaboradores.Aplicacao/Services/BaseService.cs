using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IMapper _mapper;

        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Add(string userId, TEntity obj)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TEntity> GetAll(string userId)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(string userId, string id)
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
