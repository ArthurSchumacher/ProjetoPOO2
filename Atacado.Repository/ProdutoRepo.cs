using System.Linq.Expressions;
using Atacado.DB.EF.Database;
using Microsoft.EntityFrameworkCore;

namespace Atacado.Repository;

public class ProdutoRepo : BaseAtacadoContextRepo<Produto>
{
    public ProdutoRepo(AtacadoContext ctx) : base(ctx)
    {
    }

    public override Produto Create(Produto obj)
    {
        context.Produtos.Add(obj);
        context.SaveChanges();
        return obj;
    }

    public override Produto Delete(int codigo)
    {
        Produto alvo = this.Read(codigo);
        context.Produtos.Remove(alvo);
        context.SaveChanges();
        return alvo;
    }

    public override Produto Read(int codigo)
    {
        return context.Produtos.SingleOrDefault(item => item.Codigo == codigo);
    }

    public override List<Produto> Read()
    {
        return context.Produtos.ToList();
    }

    public override List<Produto> Read(Expression<Func<Produto, bool>> predicado)
    {
        return context.Produtos.Where(predicado).ToList();
    }

    public override Produto Update(Produto obj)
    {
        context.Produtos.Attach(obj);
        context.Entry<Produto>(obj).State 
            = EntityState.Modified;
        context.SaveChanges();
        return obj;
    }
}