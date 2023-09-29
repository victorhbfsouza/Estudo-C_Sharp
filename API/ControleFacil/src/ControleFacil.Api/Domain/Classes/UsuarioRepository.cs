using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Data;
using ControleFacil.Api.Domain.Interfaces;
using ControleFacil.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFacil.Api.Domain.Classes
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly ApplicationContext _contexto;
        public UsuarioRepository(ApplicationContext context)
        {
            _contexto = context;
        }
        public async Task<Usuario> Adicionar(Usuario entidade)
        {
            await _contexto.Usuario.AddAsync(entidade);
            await _contexto.SaveChangesAsync();

            return entidade;
        }

        public async Task<Usuario> Atualizar(Usuario entidade)
        {
            Usuario entidadeBanco = _contexto.Usuario
            .Where(u => u.Id == entidade.Id)
            .FirstOrDefault();

            _contexto.Entry(entidadeBanco).CurrentValues.SetValues(entidade);
            _contexto.Update<Usuario>(entidadeBanco);

            await _contexto.SaveChangesAsync();

            return entidadeBanco;
        }

        public async Task Deletar(Usuario entidade)
        {
            //Deleção fisica, deleta primeiro no contexto e depois no banco
            _contexto.Entry(entidade).State = EntityState.Deleted;
            await _contexto.SaveChangesAsync();
        }

        public async Task<Usuario?> Obter(string email)
        {
            return await _contexto.Usuario.AsNoTracking()
            .Where(u => u.Email == email)
            .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Usuario>> Obter()
        {
            return await _contexto.Usuario.AsNoTracking()
            .OrderBy(u => u.Id).ToListAsync();
        }

        public async Task<Usuario?> Obter(long id)
        {
            return await _contexto.Usuario.AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        }
    }
}