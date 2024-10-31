using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BBrownieMVC.Models;

namespace BBrownieMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BBrownieMVC.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<BBrownieMVC.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<BBrownieMVC.Models.Produto> Produto { get; set; } = default!;
        public DbSet<BBrownieMVC.Models.Venda> Venda { get; set; } = default!;
    }
}
