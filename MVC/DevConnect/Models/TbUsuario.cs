using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E6164074C6B43", IsUnique = true)]
[Index("NomeUsuario", Name = "UQ__tb_usuar__CCB80B0AD1082EC7", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome_completo")]
    [StringLength(255)]
    public string NomeCompleto { get; set; } = null!;

    [Column("nome_usuario")]
    [StringLength(50)]
    public string NomeUsuario { get; set; } = null!;

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(50)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfil_url")]
    [StringLength(150)]
    public string? FotoPerfilUrl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbComentario> TbComentarios { get; set; } = new List<TbComentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtidum> TbCurtida { get; set; } = new List<TbCurtidum>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPublicacao> TbPublicacaos { get; set; } = new List<TbPublicacao>();
}
