using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Repositorios;

public class PedidoRepositorio: RepositorioBase<Pedido>, IPedidoRepositorio
{
    public PedidoRepositorio(AppDbContext dbContext) : base(dbContext)
    {
    }

    public override async Task<IEnumerable<Pedido>> ListarAsync()
    {
        return await _dbSet.Include(a=>a.ItensPedidos).ThenInclude(a=>a.Produto).AsNoTracking().ToListAsync();
    }

    public override async Task<Pedido?> ObterAsync(int id)
    {
        return await _dbSet.Include(a => a.ItensPedidos).ThenInclude(a => a.Produto).Where(a => a.Id == id).FirstOrDefaultAsync();
    }
}
