using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloIdeal.Domain.Entidade
{
    public class ContContabil
    {
        public int? CoCo_Codigo { get; set; }
        public string CoCo_Nome { get; set; }

        public bool IsValid(ContContabil contContabil)
        {
            return !string.IsNullOrEmpty(contContabil.CoCo_Nome);
        }
    }
}
