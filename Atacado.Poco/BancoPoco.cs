namespace Atacado.Poco;

public class BancoPoco
{
    public int CodigoBanco { get; set; }
    public int CodigoBacen { get; set; }
    public string Descricao { get; set; } = null!;
    public string SiteBanco { get; set; } = null!;
    public bool Situacao { get; set; }
    public DateTime DataInclusao { get; set; }
}
