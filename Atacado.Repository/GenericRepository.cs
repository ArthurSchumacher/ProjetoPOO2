using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository;

public class GenericRepository<TModel> : IBaseRepositorio<TModel> where TModel : class
{
    private DbContext _context;
    private DbSet<TModel> _table;

    public GenericRepository(DbContext context)
    {
        _context = context;
        _table = _context.Set<TModel>();
    }

    public TModel Create(TModel obj)
    {
        _table.Add(obj);
        _context.SaveChanges();
        return obj;
    }

    public TModel Delete(int id)
    {
        TModel obj = Read(id);
        _table.Remove(obj);
        _context.SaveChanges();
        return obj;
    }

    public TModel Read(int id)
    {
        return _table.Find(id);
    }

    public List<TModel> Read()
    {
        return _table.ToList();
    }

    public IQueryable<TModel> Read(Expression<Func<TModel, bool>> predicado)
    {
        return _table.Where(predicado);
    }

    public TModel Update(TModel obj)
    {
        _table.Attach(obj);
        _context.Entry(obj).State = EntityState.Modified;
        _context.SaveChanges();
        return obj;
    }
}
