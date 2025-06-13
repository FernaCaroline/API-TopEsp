using Microsoft.EntityFrameworkCore;
using CadastroFuncionariosApi.Models;

namespace CadastroFuncionariosApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Funcionario>().HasData(
                 new Funcionario { Id = 1, Nome = "Fernanda", Cargo = "Analista" },
                new Funcionario { Id = 2, Nome = "Alexandre", Cargo = "Desenvolvedor" },
                new Funcionario { Id = 3, Nome = "Tiago", Cargo = "Coordenador" },
                new Funcionario { Id = 4, Nome = "Marcelo", Cargo = "TI" },
                new Funcionario { Id = 5, Nome = "Bernadete", Cargo = "RH" },
                new Funcionario { Id = 6, Nome = "Fabrício", Cargo = "Financeiro" },
                new Funcionario { Id = 7, Nome = "Diogo", Cargo = "Suporte" },
                new Funcionario { Id = 8, Nome = "Jéssica", Cargo = "Comercial" },
                new Funcionario { Id = 9, Nome = "Karoline", Cargo = "Marketing" },
                new Funcionario { Id = 10, Nome = "Jaqueline", Cargo = "Administrativo" }
            );
        }
    }
}