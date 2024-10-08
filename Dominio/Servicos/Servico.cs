using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;

namespace Dominio.Servicos;

public abstract class Servico<T> : IServico<T> where T : EntidadeBase
{
    protected readonly IRepositorio<T> _repositorio;

    public Servico(IRepositorio<T> repositorio)
    {
        _repositorio = repositorio;
    }

    public virtual async Task AtualizarAsync(T entity)
    {
        await _repositorio.AtualizarAsync(entity);
    }

    public virtual async Task CriarAsync(T entity)
    {
        await _repositorio.CriarAsync(entity);
    }

    public virtual async Task ExcluirAsync(T entity)
    {
        await _repositorio.ExcluirAsync(entity);
    }

    public virtual async Task<IEnumerable<T>> ListarAsync()
    {
        return await _repositorio.ListarAsync();
    }

    public virtual async Task<T?> ObterAsync(int id)
    {
        return await _repositorio.ObterAsync(id);
    }
}
