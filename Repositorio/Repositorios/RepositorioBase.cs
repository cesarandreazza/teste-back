using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;

namespace Repositorio.Repositorios;

public abstract class RepositorioBase<T> : IRepositorio<T> where T : EntidadeBase, new()
{
    readonly AppDbContext _dbContext;
    protected DbSet<T> _dbSet;
    public RepositorioBase(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public virtual async Task AtualizarAsync(T entity)
    {
        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task CriarAsync(T entity)
    {
        _dbSet.Add(entity);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task ExcluirAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task<IEnumerable<T>> ListarAsync()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public virtual async Task<T?> ObterAsync(int id)
    {
        return await _dbSet.Where(a => a.Id == id).FirstOrDefaultAsync();
    }
}
