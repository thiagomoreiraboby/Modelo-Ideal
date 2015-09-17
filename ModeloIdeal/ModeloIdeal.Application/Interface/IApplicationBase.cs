using System.Collections.Generic;

namespace ModeloIdeal.Application.Interface
{
    public interface IApplicationBase<T> where T :class
    {
        void Salvar(T obj);
        void Deletar(T obj);
        T GetEtidade(int id);
        IEnumerable<T> GetEtidadesAll();
        void Dispose();
    }
}