
using ModeloIdeal.Domain.Entidade;

using ModeloIdeal.Domain.Interface.Repository;
using ModeloIdeal.Domain.Interface.Services;

namespace ModeloIdeal.Domain.Services
{
    public class ContContabilService : ServiceBase<ContContabil>, IContContabilService
    {
        private readonly IContContabilRepository _contContabilRepository;

        public ContContabilService(IContContabilRepository contContabilRepository)
            :base(contContabilRepository)
        {
            _contContabilRepository = contContabilRepository;
        }

        public bool IsValid(ContContabil contContabil)
        {
            return contContabil.IsValid(contContabil);
        }
    }
}