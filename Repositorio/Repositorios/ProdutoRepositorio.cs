using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;

namespace Repositorio.Repositorios;

public class ProdutoRepositorio: RepositorioBase<Produto>, IProdutoRepositorio
{
    public ProdutoRepositorio(AppDbContext dbContext) : base(dbContext)
    {
    }
}
