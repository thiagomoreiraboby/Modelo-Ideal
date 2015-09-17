using System;
using System.Collections.Generic;
using ModeloIdeal.Domain.Interface.Repository;
using ModeloIdeal.Domain.Interface.Services;

namespace ModeloIdeal.Domain.Services
{
    public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Deletar(T obj)
        {
            _repositoryBase.Deletar(obj);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public T GetEtidade(int id)
        {
            return _repositoryBase.GetEtidade(id);
        }

        public IEnumerable<T> GetEtidadesAll()
        {
            return _repositoryBase.GetEtidadesAll();
        }

        public void Salvar(T obj)
        {
            _repositoryBase.Salvar(obj);
        }
    }
}
