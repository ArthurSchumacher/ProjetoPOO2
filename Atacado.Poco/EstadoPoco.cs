namespace Atacado.Poco;

public class EstadoPoco
{
    public Int64 CodigoEstado { get; set; }
    public string Nome { get; set; } = null!;
    public string Uf { get; set; } = null!;
    public virtual Int64 CodigoRegiao { get; set; }
}
