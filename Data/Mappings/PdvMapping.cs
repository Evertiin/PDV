using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaPdv.Models;
using System.Data.Entity.ModelConfiguration;

namespace SistemaPdv.Data.Mappings
{
    public class PdvMapping : EntityTypeConfiguration<Cliente>
    {
        public void  Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Comanda> builder)
        {
            builder.ToTable("Comanda");

            builder.HasKey(x => x.Numero);

            builder.Property(x => x.Numero)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<ComprovanteDeVenda> builder)
        {
            builder.ToTable("ComprovanteDeVenda");

            builder.HasKey(x => x.NumeroVenda);

            builder.Property(x => x.NumeroVenda)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Gerente> builder)
        {
            builder.ToTable("Gerente");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Login");

            builder.HasKey(x => x.UserID);

            builder.Property(x => x.UserID)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.ToTable("Transacao");

            builder.HasKey(x => x.Numero);

            builder.Property(x => x.Numero)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }

        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Venda");

            builder.HasKey(x => x.Numero);

            builder.Property(x => x.Numero)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

        }
    }
}
