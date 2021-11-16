using Avurto.Dominio;
using Avurto.Dominio.Entidades;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Infra.Data.Contexts
{
    public class AvurtoContexts : DbContext
    {
        // Passamos o argumento de options que será definido na startup da api
        public AvurtoContexts(DbContextOptions<AvurtoContexts> options) : base(options)
        {

        }
        

        // Declarar quais são as tabelas que nós vamos criar, com dbset
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Professor> Professors { get; set; }

        // Modelamos como as tabelas devem ficar
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ignoramos que a lib de notificações do Flunt seja gerada automaticamente
            modelBuilder.Ignore<Notification>();

            #region mapeamento da tabela Usuarios

            // Mudamos o nome da tabela se necessário
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            // Determinar chaves
            modelBuilder.Entity<Usuario>().Property(x => x.Id);

            // Nome
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasColumnType("varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired();

            // Sobrenome
            modelBuilder.Entity<Usuario>().Property(x => x.Sobrenome).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Sobrenome).HasColumnType("varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Sobrenome).IsRequired();

            // Email
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnType("varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Email).IsRequired();

            // Senha
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasColumnType("varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).IsRequired();

            #endregion


            base.OnModelCreating(modelBuilder);
        }
    }
}
