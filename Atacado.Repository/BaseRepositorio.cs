using System.Linq.Expressions;
namespace Atacado.Repository;

public abstract class BaseRepositorio<TModel> where TModel : class
{
    public abstract TModel Create(TModel obj);
    public abstract TModel Read(int id);
    public abstract List<TModel> Read();
    public abstract List<TModel> Read(Expression<Func<TModel, bool>> predicado);
    public abstract TModel Update(TModel obj);
    public abstract TModel Delete(int id);
}
