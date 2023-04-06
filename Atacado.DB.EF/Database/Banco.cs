using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database;

[Table("Banco")]
public partial class Banco
{
    [Key]
    public int CodigoBanco { get; set; }

    public int CodigoBacen { get; set; }

    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    [Unicode(false)]
    public string SiteBanco { get; set; } = null!;

    public bool Situacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataInclusao { get; set; }

    public override string ToString()
    {
        return $"{CodigoBanco} - {Descricao}";
    }
}