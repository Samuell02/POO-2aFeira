
using aula12_ef_test.Domain;
using aula14_ef_repositories.Domain;
using Microsoft.EntityFrameworkCore;

namespace aula12_ef_test.Data
{
    public class DataContext : DbContext
    {
       public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestEfSegunda.db");
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Pessoa> People { get; set; }
        public DbSet<Produto> Products { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

    }
}