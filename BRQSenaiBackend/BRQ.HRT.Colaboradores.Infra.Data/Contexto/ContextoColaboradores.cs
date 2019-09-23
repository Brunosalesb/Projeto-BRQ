using System;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BRQ.HRT.Colaboradores.Infra.Data
{
    public partial class ContextoColaboradores : DbContext
    {
        public ContextoColaboradores()
        {
        }

        public ContextoColaboradores(DbContextOptions<ContextoColaboradores> options)
            : base(options)
        {
        }

        public virtual DbSet<Experiencia> Experiencia { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SkillsPessoa> SkillsPessoa { get; set; }
        public virtual DbSet<TipoExperiencia> TipoExperiencia { get; set; }
        public virtual DbSet<TipoSkill> TipoSkill { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=collaboratordev.database.windows.net;Initial Catalog=brq_senai;Persist Security Info=True;User ID=brqsenai;Password=@Senai132");
                //optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=brq_senai; Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experiencia>(entity =>
            {
                entity.HasKey(e => e.IdExperiencia);

                entity.ToTable("experiencia");

                entity.Property(e => e.IdExperiencia).HasColumnName("idExperiencia");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("text");

                entity.Property(e => e.DtFim)
                    .HasColumnName("dtFim")
                    .HasColumnType("date");

                entity.Property(e => e.DtInicio)
                    .HasColumnName("dtInicio")
                    .HasColumnType("date");

                entity.Property(e => e.IdPessoa).HasColumnName("idPessoa");

                entity.Property(e => e.IdTipoExperiencia).HasColumnName("idTipoExperiencia");

                entity.Property(e => e.Instituicao)
                    .IsRequired()
                    .HasColumnName("instituicao")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.Experiencia)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__experienc__idPes__2645B050");

                entity.HasOne(d => d.IdTipoExperienciaNavigation)
                    .WithMany(p => p.Experiencia)
                    .HasForeignKey(d => d.IdTipoExperiencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__experienc__idTip__25518C17");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.ToTable("pessoa");

                entity.HasIndex(e => e.Cpf)
                    .HasName("UQ__pessoa__D836E71FD8A14189")
                    .IsUnique();

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__pessoa__AB6E61640A389535")
                    .IsUnique();

                entity.HasIndex(e => e.Matricula)
                    .HasName("UQ__pessoa__30962D15459B1BB5")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasColumnName("bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("cep")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DtNasc)
                    .HasColumnName("dtNasc")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasColumnName("logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula).HasColumnName("matricula");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("rg")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasColumnName("telefone")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.IdSkill);

                entity.ToTable("skill");

                entity.HasIndex(e => e.NomeSkill)
                    .HasName("UQ__skill__D99B4A11EEB75189")
                    .IsUnique();

                entity.Property(e => e.IdSkill).HasColumnName("idSkill");

                entity.Property(e => e.IdTipoSkill).HasColumnName("idTipoSkill");

                entity.Property(e => e.NomeSkill)
                    .IsRequired()
                    .HasColumnName("nomeSkill")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoSkillNavigation)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.IdTipoSkill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skill__idTipoSki__17036CC0");
            });

            modelBuilder.Entity<SkillsPessoa>(entity =>
            {
                entity.HasKey(e => e.IdSkillPessoa);

                entity.ToTable("skills_pessoa");

                entity.Property(e => e.IdSkillPessoa).HasColumnName("idSkillPessoa");

                entity.Property(e => e.IdPessoa).HasColumnName("idPessoa");

                entity.Property(e => e.IdSkill).HasColumnName("idSkill");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.SkillsPessoa)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skills_pe__idPes__29221CFB");

                entity.HasOne(d => d.IdSkillNavigation)
                    .WithMany(p => p.SkillsPessoa)
                    .HasForeignKey(d => d.IdSkill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skills_pe__idSki__2A164134");
            });

            modelBuilder.Entity<TipoExperiencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoExperiencia);

                entity.ToTable("tipoExperiencia");

                entity.HasIndex(e => e.NomeTipoExperiencia)
                    .HasName("UQ__tipoExpe__0E05FF0E47143C6F")
                    .IsUnique();

                entity.Property(e => e.IdTipoExperiencia).HasColumnName("idTipoExperiencia");

                entity.Property(e => e.NomeTipoExperiencia)
                    .IsRequired()
                    .HasColumnName("nomeTipoExperiencia")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSkill>(entity =>
            {
                entity.HasKey(e => e.IdTipoSkill);

                entity.ToTable("tipoSkill");

                entity.HasIndex(e => e.NomeTipoSkill)
                    .HasName("UQ__tipoSkil__A352A3CBFA252030")
                    .IsUnique();

                entity.Property(e => e.IdTipoSkill).HasColumnName("idTipoSkill");

                entity.Property(e => e.NomeTipoSkill)
                    .IsRequired()
                    .HasColumnName("nomeTipoSkill")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
