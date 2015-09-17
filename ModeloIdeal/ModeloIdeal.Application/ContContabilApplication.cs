using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloIdeal.Application.Interface;
using ModeloIdeal.Domain.Entidade;
using ModeloIdeal.Domain.Interface.Services;

namespace ModeloIdeal.Application
{
    public class ContContabilApplication : ApplicationBase<ContContabil>, IContContContabilApplication
    {
        private readonly IContContabilService _contContabilService;

        public ContContabilApplication(IContContabilService contContabilService)
            :base(contContabilService)
        {
            _contContabilService = contContabilService;
        }

        public bool IsValid(ContContabil contContabil)
        {
            return _contContabilService.IsValid(contContabil);
        }
    }
}
