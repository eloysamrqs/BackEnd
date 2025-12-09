using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[PrimaryKey("IdUsuarioSeguir", "IdUsuarioSeguida")]
[Table("tb_seguidor")]
public partial class TbSeguidor
{
    [Key]
    [Column("id_usuario_seguir")]
    public int IdUsuarioSeguir { get; set; }

    [Key]
    [Column("id_usuario_seguida")]
    public int IdUsuarioSeguida { get; set; }
}
