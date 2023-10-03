using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Contract.Apagar
{
    public class ApagarResponseContract : ApagarRequestContract
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime? DataDeInativacao { get; set; }
    }
}