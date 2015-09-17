using ModeloIdeal.Domain.Entidade;

namespace ModeloIdeal.Application.Interface
{
    public interface IContContContabilApplication: IApplicationBase<ContContabil>
    {
        bool IsValid(ContContabil contContabil);
    }
}