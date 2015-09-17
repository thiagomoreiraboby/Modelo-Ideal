
using ModeloIdeal.Domain.Entidade;

namespace ModeloIdeal.Domain.Interface.Services
{
    public interface IContContabilService : IServiceBase<ContContabil>
    {
        bool IsValid(ContContabil contContabil);
    }
}
