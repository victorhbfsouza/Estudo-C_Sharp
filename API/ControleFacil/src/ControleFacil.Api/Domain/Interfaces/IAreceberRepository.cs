using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Models;

namespace ControleFacil.Api.Domain.Interfaces
{
    public interface IAreceberRepository : IRepository<Areceber, long>
    {
        Task<IEnumerable<Areceber>> ObterPeloIdUsuario(long ObterPeloIdUsuario);
    }
}