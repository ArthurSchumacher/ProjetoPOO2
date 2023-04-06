using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.DB.EF.Database
{
    [Table("Subcategoria")]
    public partial class Subcategoria
    {
        [Key]
        public int Codigo { get; set; }

        public int CodigoCategoria { get; set; }

        [Unicode(false)]
        public string Descricao { get; set; } = null!;

        public bool Ativo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DataInclusao { get; set; }

        public Subcategoria()
        {
        }

        public override string ToString()
        {
            return $"{Codigo} - {CodigoCategoria} - {Descricao}";
        }
    }
}
