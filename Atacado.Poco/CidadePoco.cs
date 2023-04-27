namespace Atacado.Poco;

public class CidadePoco
{
    public Int64 CodigoCidade { get; set; }
    public string Nome { get; set; }
    public Int64 CodigoIBGE7 { get; set; }
    public string UF { get; set; }
    public virtual Int64 CodigoEstado { get; set; }
}
