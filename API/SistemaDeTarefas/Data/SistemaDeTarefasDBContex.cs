﻿using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Controllers;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasDBContex : DbContext 
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options) 
            : base(options) 
        {
        }

        public DbSet<TarefaModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
