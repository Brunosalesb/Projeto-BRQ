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

        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Experiencia> Experiencia { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SkillPessoa> SkillPessoa { get; set; }
        public virtual DbSet<TipoContato> TipoContato { get; set; }
        public virtual DbSet<TipoExperiencia> TipoExperiencia { get; set; }
        public virtual DbSet<TipoSkill> TipoSkill { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // diretiva de #aviso
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:brqsenai.database.windows.net,1433;Initial Catalog=HTRSenaiColaboradores;Persist Security Info=False;User ID=brqsenai;Password=@Senai132;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
#pragma warning restore CS1030 // diretiva de #aviso
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.IdContato);

                entity.ToTable("contato");

                entity.HasIndex(e => e.Contato1)
                    .HasName("UQ__contato__870056B9DFB9BF82")
                    .IsUnique();

                entity.Property(e => e.IdContato).HasColumnName("idContato");

                entity.Property(e => e.Contato1)
                    .IsRequired()
                    .HasColumnName("contato")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FkIdPessoa).HasColumnName("fk_idPessoa");

                entity.Property(e => e.FkIdTipoContato).HasColumnName("fk_idTipoContato");

                entity.HasOne(d => d.FkIdPessoaNavigation)
                    .WithMany(p => p.Contato)
                    .HasForeignKey(d => d.FkIdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__contato__fk_idPe__59FA5E80");

                entity.HasOne(d => d.FkIdTipoContatoNavigation)
                    .WithMany(p => p.Contato)
                    .HasForeignKey(d => d.FkIdTipoContato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__contato__fk_idTi__59063A47");
            });

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

                entity.Property(e => e.FkIdPessoa).HasColumnName("fk_idPessoa");

                entity.Property(e => e.FkIdTipoExperiencia).HasColumnName("fk_idTipoExperiencia");

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

                entity.HasOne(d => d.FkIdPessoaNavigation)
                    .WithMany(p => p.Experiencia)
                    .HasForeignKey(d => d.FkIdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__experienc__fk_id__60A75C0F");

                entity.HasOne(d => d.FkIdTipoExperienciaNavigation)
                    .WithMany(p => p.Experiencia)
                    .HasForeignKey(d => d.FkIdTipoExperiencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__experienc__fk_id__5FB337D6");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.IdPessoa);

                entity.ToTable("pessoa");

                entity.HasIndex(e => e.Cpf)
                    .HasName("UQ__pessoa__D836E71F26092FB6")
                    .IsUnique();

                entity.HasIndex(e => e.Matricula)
                    .HasName("UQ__pessoa__30962D1586B48943")
                    .IsUnique();

                entity.HasIndex(e => e.Rg)
                    .HasName("UQ__pessoa__321433103FD21E78")
                    .IsUnique();

                entity.Property(e => e.IdPessoa).HasColumnName("idPessoa");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnName("cpf")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtNasc)
                    .HasColumnName("dtNasc")
                    .HasColumnType("date");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .HasColumnName("logradouro")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasColumnName("matricula")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasColumnName("rg")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.IdSkill);

                entity.ToTable("skill");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__skill__6F71C0DCFF718E92")
                    .IsUnique();

                entity.Property(e => e.IdSkill).HasColumnName("idSkill");

                entity.Property(e => e.FkIdTipoSkill).HasColumnName("fk_idTipoSkill");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIdTipoSkillNavigation)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.FkIdTipoSkill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skill__fk_idTipo__4D94879B");
            });

            modelBuilder.Entity<SkillPessoa>(entity =>
            {
                entity.HasKey(e => e.IdSkillPessoa);

                entity.ToTable("skill_pessoa");

                entity.Property(e => e.IdSkillPessoa).HasColumnName("idSkillPessoa");

                entity.Property(e => e.FkIdPessoa).HasColumnName("fk_idPessoa");

                entity.Property(e => e.FkIdSkill).HasColumnName("fk_idSkill");

                entity.HasOne(d => d.FkIdPessoaNavigation)
                    .WithMany(p => p.SkillPessoa)
                    .HasForeignKey(d => d.FkIdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skill_pes__fk_id__6383C8BA");

                entity.HasOne(d => d.FkIdSkillNavigation)
                    .WithMany(p => p.SkillPessoa)
                    .HasForeignKey(d => d.FkIdSkill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__skill_pes__fk_id__6477ECF3");
            });

            modelBuilder.Entity<TipoContato>(entity =>
            {
                entity.HasKey(e => e.IdTipoContato);

                entity.ToTable("tipoContato");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__tipoCont__6F71C0DC750AD411")
                    .IsUnique();

                entity.Property(e => e.IdTipoContato).HasColumnName("idTipoContato");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoExperiencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoExperiencia);

                entity.ToTable("tipoExperiencia");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__tipoExpe__6F71C0DCDBF7BB7B")
                    .IsUnique();

                entity.Property(e => e.IdTipoExperiencia).HasColumnName("idTipoExperiencia");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSkill>(entity =>
            {
                entity.HasKey(e => e.IdTipoSkill);

                entity.ToTable("tipoSkill");

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__tipoSkil__6F71C0DC144E27BA")
                    .IsUnique();

                entity.Property(e => e.IdTipoSkill).HasColumnName("idTipoSkill");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
