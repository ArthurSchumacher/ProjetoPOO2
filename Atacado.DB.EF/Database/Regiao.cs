using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database;

[Table("Regiao")]
public partial class Regiao
{
    [Key]
    public Int64 CodigoRegiao { get; set; }

    [Unicode(false)]
    public string Nome { get; set; } = null!;

    public Regiao()
    {
    }

    public override string ToString()
    {
        return $"{CodigoRegiao} - {Nome}";
    }
}
