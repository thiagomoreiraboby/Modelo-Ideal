using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloIdeal.Application.Interface;
using ModeloIdeal.Domain.Interface.Services;

namespace ModeloIdeal.Application
{
    public class ApplicationBase<T> : IApplicationBase<T> where T : class
    {
        private readonly IServiceBase<T> _serviceBase;

        public ApplicationBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Deletar(T obj)
        {
            _serviceBase.Deletar(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public T GetEtidade(int id)
        {
            return _serviceBase.GetEtidade(id);
        }

        public IEnumerable<T> GetEtidadesAll()
        {
            return _serviceBase.GetEtidadesAll();
        }

        public void Salvar(T obj)
        {
            _serviceBase.Salvar(obj);
        }
    }
}
