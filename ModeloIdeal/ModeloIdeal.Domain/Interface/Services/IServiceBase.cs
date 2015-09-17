using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIdeal.Domain.Interface.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Salvar(T obj);
        void Deletar(T obj);
        T GetEtidade(int id);
        IEnumerable<T> GetEtidadesAll();
        void Dispose();
    }
}
