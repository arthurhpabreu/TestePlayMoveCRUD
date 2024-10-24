using Microsoft.EntityFrameworkCore;
using TestePlayMoveCRUD.Model.Entities;

namespace TestePlayMoveCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }

    }
}
