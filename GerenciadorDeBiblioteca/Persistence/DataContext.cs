using GerenciadorDeBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeBiblioteca.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Emprestimo> Emprestimo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>(e =>
            {
                e.HasKey(l => l.Id);
            });

            modelBuilder.Entity<Usuario>(e =>
            {
                e.HasKey(s => s.Id);
            });

            modelBuilder.Entity<Emprestimo>(e =>
            {
                e.HasKey(s => s.Id);

                e.HasOne<Usuario>()
                    .WithMany()
                    .HasForeignKey(e => e.IdUsuario)
                    .OnDelete(DeleteBehavior.Restrict);

                e.HasOne<Livro>()
                     .WithMany()
                     .HasForeignKey(e => e.IdLivro)
                     .OnDelete(DeleteBehavior.Restrict);
            });

        }
    }
}
