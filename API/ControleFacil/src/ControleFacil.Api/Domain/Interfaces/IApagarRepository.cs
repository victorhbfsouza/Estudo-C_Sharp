using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Models;

namespace ControleFacil.Api.Domain.Interfaces
{
    public interface IApagarRepository : IRepository<Apagar, long>
    {
        Task<IEnumerable<Apagar>> ObterPeloIdUsuario(long ObterPeloIdUsuario);
    }
}