using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database;

[Table("Cidade")]
public class Cidade
{

    [Key]
    public Int64 CodigoCidade { get; set; }

    [Unicode(false)]
    public string Nome { get; set; } = null!;

    public Int64 CodigoIBGE7 { get; set; }

    [Unicode(false)]
    public string UF { get; set; } = null!;

    public virtual Int64 CodigoEstado { get; set; }

    public Cidade()
    {
    }

    public override string ToString()
    {
        return $"{CodigoCidade} - {Nome} -> {CodigoEstado}";
    }
}
