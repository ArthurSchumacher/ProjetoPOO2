using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database;

[Table("Estado")]
public partial class Estado
{

    [Key]
    public Int64 CodigoEstado { get; set; }

    [Unicode(false)]
    public string Nome { get; set; } = null!;

    [Unicode(false)]
    public string Uf { get; set; } = null!;

    [ForeignKey("CodigoRegiao")]
    public virtual Int64 CodigoRegiao { get; set; }

    public Estado()
    {
    }

    public override string ToString()
    {
        return $"{CodigoEstado} - {Nome}-{Uf} -> {CodigoRegiao}";
    }

}
