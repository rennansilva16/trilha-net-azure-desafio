using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrilhaNetAzureDesafio.Models;

namespace TrilhaNetAzureDesafio.Context
{
    public class RHContext : DbContext
    {
        public RHContext(DbContextOptions<RHContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar o tipo de coluna para a propriedade Salario
            modelBuilder.Entity<Funcionario>()
                .Property(f => f.Salario)
                .HasColumnType("decimal(18,2)");
        }
    }
}