using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai_hroads_webAPI.Domains;

#nullable disable

namespace senai_hroads_webAPI.Contexts
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<Classehabilidade> Classehabilidades { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Personagem> Personagems { get; set; }
        public virtual DbSet<Tipohabilidade> Tipohabilidades { get; set; }
        public virtual DbSet<Tipousuario> Tipousuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=NOTE0113D1\\SQLEXPRESS; Database=HROADS; user id=sa; pwd=Senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__CLASSE__60FFF8018E3F66FF");

                entity.ToTable("CLASSE");

                entity.HasIndex(e => e.NomeClasse, "UQ__CLASSE__F1ED81020E3E3A39")
                    .IsUnique();

                entity.Property(e => e.IdClasse)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idClasse");

                entity.Property(e => e.NomeClasse)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nomeClasse");
            });

            modelBuilder.Entity<Classehabilidade>(entity =>
            {
                entity.HasKey(e => e.IdClasseHabi)
                    .HasName("PK__CLASSEHA__3AD3FB119B5DE66B");

                entity.ToTable("CLASSEHABILIDADE");

                entity.Property(e => e.IdClasseHabi)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idClasseHabi");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Classehabilidades)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__CLASSEHAB__idCla__49C3F6B7");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany(p => p.Classehabilidades)
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__CLASSEHAB__idHab__4AB81AF0");
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__HABILIDA__655F75283749CB7A");

                entity.ToTable("HABILIDADE");

                entity.HasIndex(e => e.NomeHabilidade, "UQ__HABILIDA__08EF5E0CCE2F45E9")
                    .IsUnique();

                entity.Property(e => e.IdHabilidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idHabilidade");

                entity.Property(e => e.IdTipoHabilidade).HasColumnName("idTipoHabilidade");

                entity.Property(e => e.NomeHabilidade)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nomeHabilidade");

                entity.HasOne(d => d.IdTipoHabilidadeNavigation)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTipoHabilidade)
                    .HasConstraintName("FK__HABILIDAD__idTip__46E78A0C");
            });

            modelBuilder.Entity<Personagem>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__PERSONAG__E175C72EADA8447A");

                entity.ToTable("PERSONAGEM");

                entity.HasIndex(e => e.NomePersonagem, "UQ__PERSONAG__2075C7B80EF8C70F")
                    .IsUnique();

                entity.HasIndex(e => e.QtdMaxMana, "UQ__PERSONAG__3A54DE498395C23D")
                    .IsUnique();

                entity.HasIndex(e => e.QtdMaxVida, "UQ__PERSONAG__B2B3C1E6A49EF5BB")
                    .IsUnique();

                entity.Property(e => e.IdPersonagem)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idPersonagem");

                entity.Property(e => e.DataAtualizacao)
                    .HasColumnType("date")
                    .HasColumnName("dataAtualizacao");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("date")
                    .HasColumnName("dataCriacao");

                entity.Property(e => e.IdClasseHabi).HasColumnName("idClasseHabi");

                entity.Property(e => e.NomePersonagem)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nomePersonagem");

                entity.Property(e => e.QtdMaxMana).HasColumnName("qtdMaxMana");

                entity.Property(e => e.QtdMaxVida).HasColumnName("qtdMaxVida");

                entity.HasOne(d => d.IdClasseHabiNavigation)
                    .WithMany(p => p.Personagems)
                    .HasForeignKey(d => d.IdClasseHabi)
                    .HasConstraintName("FK__PERSONAGE__idCla__5070F446");
            });

            modelBuilder.Entity<Tipohabilidade>(entity =>
            {
                entity.HasKey(e => e.IdTipoHabilidade)
                    .HasName("PK__TIPOHABI__B197B83260297C62");

                entity.ToTable("TIPOHABILIDADE");

                entity.Property(e => e.IdTipoHabilidade)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idTipoHabilidade");

                entity.Property(e => e.TipoHabilidade1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipoHabilidade");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<Tipousuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TIPOUSUA__03006BFF5FB2D3EB");

                entity.ToTable("TIPOUSUARIO");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TipoUsuario1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipoUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIO__645723A6ADDE5913");

                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email, "UQ__USUARIO__AB6E61640FB6BEB0")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__USUARIO__idTipoU__5629CD9C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
