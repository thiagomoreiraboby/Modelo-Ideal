using System.Collections.Generic;

namespace ModeloIdeal.Domain.Interface.Repository
{
    public interface IRepositoryBase<T> where T: class
    {
        void Salvar(T obj);
        void Deletar(T obj);
        T GetEtidade(int id);
        IEnumerable<T> GetEtidadesAll();
        void Dispose();

    }
}