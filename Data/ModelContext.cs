using Microsoft.EntityFrameworkCore;
using SistemaPdv.Models;

namespace SistemaPdv.Data
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComprovanteDeVenda> ComprovanteDeVendas { get; set; }
        public DbSet<FluxoDeCaixa> FluxoDeCaixas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Gerente>   Gerentes { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Transacao> Transacaos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
