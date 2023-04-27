namespace Atacado.Poco;

public class EstadoPoco
{
    public Int64 CodigoEstado { get; set; }
    public string Nome { get; set; }
    public string Uf { get; set; }
    public virtual Int64 CodigoRegiao { get; set; }
}
