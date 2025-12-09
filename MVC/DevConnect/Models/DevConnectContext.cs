using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentarios { get; set; }

    public virtual DbSet<TbCurtidum> TbCurtida { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacaos { get; set; }

    public virtual DbSet<TbSeguidor> TbSeguidors { get; set; }

    public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NOTE09-S19\\SQLEXPRESS;User Id=sa; Password=senai@134; Database=db_devconnect_T;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_comen__3213E83FA195E409");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentarios).HasConstraintName("FK__tb_coment__id_pu__14270015");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentarios).HasConstraintName("FK__tb_coment__id_us__1332DBDC");
        });

        modelBuilder.Entity<TbCurtidum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_curti__3213E83F99F95E0A");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtida).HasConstraintName("FK__tb_curtid__id_pu__17F790F9");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtida).HasConstraintName("FK__tb_curtid__id_us__17036CC0");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_publi__3213E83FAAB3517D");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacaos).HasConstraintName("FK__tb_public__id_us__0E6E26BF");
        });

        modelBuilder.Entity<TbSeguidor>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuarioSeguir, e.IdUsuarioSeguida }).HasName("PK__tb_segui__CFA87AC01264623A");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83F8EBDF8BB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
