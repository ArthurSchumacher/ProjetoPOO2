using System.Linq.Expressions;
using Atacado.DB.EF.Database;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository;

public class SubcategoriaRepo : BaseAtacadoContextRepo<Subcategoria>
{
    public SubcategoriaRepo(AtacadoContext ctx) : base(ctx)
    {
    }

    public override Subcategoria Create(Subcategoria obj)
    {
        context.Subcategorias.Add(obj);
        context.SaveChanges();
        return obj;
    }

    public override Subcategoria Delete(int codigo)
    {
        Subcategoria alvo = this.Read(codigo);
        context.Subcategorias.Remove(alvo);
        context.SaveChanges();
        return alvo;
    }

    public override Subcategoria Read(int codigo)
    {
        return context.Subcategorias.SingleOrDefault(item => item.Codigo == codigo);
    }

    public override List<Subcategoria> Read()
    {
        return context.Subcategorias.ToList();
    }

    public override List<Subcategoria> Read(Expression<Func<Subcategoria, bool>> predicado)
    {
        return context.Subcategorias.Where(predicado).ToList();
    }

    public override Subcategoria Update(Subcategoria obj)
    {
        context.Subcategorias.Attach(obj);
        context.Entry<Subcategoria>(obj).State 
            = EntityState.Modified;
        context.SaveChanges();
        return obj;
    }
}