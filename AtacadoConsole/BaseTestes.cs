using Atacado.DB.EF.Database;

namespace AtacadoConsole;

public abstract class BaseTestes
{
    protected AtacadoContext _contexto;
    public BaseTestes(AtacadoContext contexto)
    {
        _contexto = contexto;
    }

    public abstract void Imprimir();
}
