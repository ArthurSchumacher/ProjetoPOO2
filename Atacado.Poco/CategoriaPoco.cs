namespace Atacado.Poco;

public class CategoriaPoco
{
    public int Codigo { get; set; }
    public string Descricao { get; set; } = null!;
    public bool Ativo { get; set; }
    public DateTime? DataInclusao { get; set; }
}
