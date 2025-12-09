using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CadAlunoTorloni.Models;

public partial class CadAlunoTorloniContext : DbContext
{
    public CadAlunoTorloniContext()
    {
    }

    public CadAlunoTorloniContext(DbContextOptions<CadAlunoTorloniContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Frutum> Fruta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NOTE09-S19\\SQLEXPRESS;User Id=sa; Password=senai@134; Database=CadAlunoTorloni;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
modelBuilder.Entity<Aluno>(entity =>
{
    entity.HasKey(e => e.Id);
});

        modelBuilder.Entity<Frutum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fruta__3214EC07BEDA9447");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

public class Alunos
{
    public int Id { get; set; } // Alterado de 'object' para 'int'
}