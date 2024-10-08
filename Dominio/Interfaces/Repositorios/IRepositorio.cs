using Dominio.Entidades;

namespace Dominio.Interfaces.Repositorios;

public interface IRepositorio<T> where T : EntidadeBase
{
    Task CriarAsync(T entity);
    Task ExcluirAsync(T entity);
    Task AtualizarAsync(T entity);
    Task<T?> ObterAsync(int id);
    Task<IEnumerable<T>> ListarAsync();
}
