using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Domain.Services.Interfaces
{
    /// <summary>
    /// Interface generica para a criação de CRUD
    /// </summary>
    /// <typeparam name="RQ">Contrato de request</typeparam>
    /// <typeparam name="RS">Contrato de response</typeparam>
    /// <typeparam name="I">Tipo do Id</typeparam> <summary>
    /// 
    public interface IService<RQ, RS, I> where RQ : class
    {
        Task<IEnumerable<RS>> Obter(I idUsuario);
        Task<RS> Obter(I id, I idUsuario);
        Task<RS> Adicionar(RQ entidade, I idUsuario);
        Task<RS> Atualizar(I id, RQ entidade, I idUsuario);
        Task<RS> Inativar(I id, I idUsuario);
    }
}