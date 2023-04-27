using Atacado.DB.EF.Database;

namespace Atacado.Repository;

public abstract class BaseAtacadoContextRepo<TModel> : BaseRepositorio<TModel> where TModel : class
{
    protected AtacadoContext context;

    public BaseAtacadoContextRepo(AtacadoContext context) : base()
    {
        this.context = context;
    }
}
