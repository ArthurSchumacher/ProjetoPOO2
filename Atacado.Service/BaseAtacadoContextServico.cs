using Atacado.DB.EF.Database;

namespace Atacado.Service;

public abstract class BaseAtacadoContextServico<TPoco, TModelEF> : BaseServico<TPoco, TModelEF>
    where TPoco : class
    where TModelEF : class
{
    protected AtacadoContext context;

    protected BaseAtacadoContextServico(AtacadoContext context) : base()
    {
        this.context = context;
    }
}
