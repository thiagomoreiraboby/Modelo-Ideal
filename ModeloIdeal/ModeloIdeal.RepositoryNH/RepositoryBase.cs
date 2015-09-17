using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloIdeal.Domain.Interface;
using ModeloIdeal.Domain.Interface.Repository;

namespace ModeloIdeal.RepositoryNH
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public void Deletar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T GetEtidade(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetEtidadesAll()
        {
            throw new NotImplementedException();
        }

        public void Salvar(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
