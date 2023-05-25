using System.Linq.Expressions;

namespace Atacado.Repository;

public interface IBaseRepositorio<TModel> where TModel : class
{
    TModel Create(TModel obj);
    TModel Read(int id);
    List<TModel> Read();
    IQueryable<TModel> Read(Expression<Func<TModel, bool>> predicado);
    TModel Update(TModel obj);
    TModel Delete(int id);
}

