using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database;

[Table("Profissao")]
public partial class Profissao
{
    [Key]
    public int ProfissaoID { get; set; }

    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DataInsert { get; set; }

    public bool Ativo { get; set; }

    public Profissao()
    {
    }
}
