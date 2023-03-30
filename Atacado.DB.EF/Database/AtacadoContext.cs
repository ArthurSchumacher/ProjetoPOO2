using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Atacado.DB.EF.Database
{
    public partial class AtacadoContext : DbContext
    {
        public AtacadoContext()
        {
        }

        public AtacadoContext(DbContextOptions<AtacadoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<Subcategoria> Subcategorias { get; set; } = null!;
        public virtual DbSet<Regiao> Regioes { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Cidade> Cidades { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(local); Initial Catalog=dbAtacado;User=usrAtacado;Password=senha123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CodigoSubcategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.CodigoSubcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto_Subcategoria");
            });

            modelBuilder.Entity<Subcategoria>(entity =>
            {
                entity.Property(e => e.DataInclusao).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CodigoCategoriaNavigation)
                    .WithMany(p => p.Subcategoria)
                    .HasForeignKey(d => d.CodigoCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subcategoria_Categoria");
            });

            modelBuilder.Entity<Regiao>();
            modelBuilder.Entity<Estado>();
            modelBuilder.Entity<Cidade>();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
