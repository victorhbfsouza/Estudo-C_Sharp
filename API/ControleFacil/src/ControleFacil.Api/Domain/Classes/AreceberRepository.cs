using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Data;
using ControleFacil.Api.Domain.Interfaces;
using ControleFacil.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFacil.Api.Domain.Classes
{
    public class AreceberRepository : IAreceberRepository
    {
        private readonly ApplicationContext _contexto;

        public AreceberRepository(ApplicationContext context)
        {
            _contexto = context;
        }
        public async Task<Areceber> Adicionar(Areceber entidade)
        {
            await _contexto.Areceber.AddAsync(entidade);
            await _contexto.SaveChangesAsync();

            return entidade;
        }

        public async Task<Areceber> Atualizar(Areceber entidade)
        {
            Areceber entidadeBanco = _contexto.Areceber
            .Where(u => u.Id == entidade.Id)
            .FirstOrDefault();

            _contexto.Entry(entidadeBanco).CurrentValues.SetValues(entidade);
            _contexto.Update<Areceber>(entidadeBanco);

            await _contexto.SaveChangesAsync();

            return entidadeBanco;
        }

        public async Task Deletar(Areceber entidade)
        {
            //Deletar lógico, só altero a data de inativação
            entidade.DataInativacao = DateTime.Now;
            await Atualizar(entidade);
        }

        public async Task<IEnumerable<Areceber>> Obter()
        {
            return await _contexto.Areceber.AsNoTracking()
                                        .OrderBy(u => u.Id)
                                        .ToListAsync();
        }

        public async Task<Areceber?> Obter(long id)
        {
            return await _contexto.Areceber.AsNoTracking()
                                        .Where(n => n.Id == id)
                                        .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Areceber>> ObterPeloIdUsuario(long idUsuario)
        {
            return await _contexto.Areceber.AsNoTracking()
                                        .Where(n => n.IdUsuario == idUsuario)
                                        .OrderBy(n => n.Id)
                                        .ToListAsync();
        }
    }
}