using System.Linq.Expressions;
using Atacado.DB.EF.Database;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository;

public class CategoriaRepo : BaseAtacadoContextRepo<Categoria>
{
    public CategoriaRepo(AtacadoContext context) : base(context)
    {
    }

    public override Categoria Create(Categoria obj)
    {
        context.Categorias.Add(obj);
        context.SaveChanges();

        return obj;
    }
    public override Categoria Read(int id)
    {
        return context.Categorias.SingleOrDefault(x => x.Codigo == id);
    }

    public override List<Categoria> Read()
    {
        return context.Categorias.ToList();
    }

    public override List<Categoria> Read(Expression<Func<Categoria, bool>> predicado)
    {
        return context.Categorias.Where(predicado).ToList();
    }

    public override Categoria Update(Categoria obj)
    {
        context.Categorias.Attach(obj);
        context.Entry<Categoria>(obj).State = EntityState.Modified;
        context.SaveChanges();
        return obj;
    }

    public override Categoria Delete(int id)
    {
        Categoria obj = Read(id);
        context.Categorias.Remove(obj);
        context.SaveChanges();
        return obj;
    }
}
