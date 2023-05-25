using System.Linq.Expressions;
namespace Atacado.Service;

public abstract class BaseServico<TPoco, TModelEF>
    where TPoco : class
    where TModelEF : class
{
    public abstract List<TPoco> Listar();
    public abstract List<TPoco> Listar(Expression<Func<TModelEF, bool>> predicado);
    public abstract TPoco Ler(int id);
    public abstract TPoco Adicionar(TPoco obj);
    public abstract TPoco Atualizar(TPoco obj);
    public abstract TPoco Remover(int id);
    public abstract TPoco Converter(TModelEF obj);
    public abstract TModelEF Converter(TPoco obj);
}
