using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Produto")]
    public partial class Produto
    {
        [Key]
        public int Codigo { get; set; }

        public int CodigoSubcategoria { get; set; }
        
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        [Column(TypeName = "decimal(7, 2)")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }
        
        public int CodigoCategoria { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Descricao}";
        }
    }
}
