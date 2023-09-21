using SistemaDeTarefas.Controllers;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositories.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<TarefaModel>> BuscarTodosUsuarios();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(TarefaModel usuario);
        Task<TarefaModel> Atualizar(TarefaModel usuario, int id);
        Task<bool> Apagar(int id);
        Task<UsuarioModel> Adicionar(object usuarioModel);
    }
}
