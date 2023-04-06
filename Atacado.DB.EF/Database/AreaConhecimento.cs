using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database;

[Table("AreaConhecimento")]
public partial class AreaConhecimento
{
    [Key]
    public int CodigoArea { get; set; }

    [Unicode(false)]
    public string Descricao { get; set; } = null!;

    public bool Situacao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DataInclusao { get; set; }

    public override string ToString()
    {
        return $"{CodigoArea} - {Descricao}";
    }
}