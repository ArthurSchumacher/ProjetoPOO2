using System.Linq.Expressions;
using Atacado.DB.EF.Database;
using Atacado.Poco;
using Atacado.Repository;

namespace Atacado.Service;

public class SubcategoriaServico
    : BaseAtacadoContextServico<SubcategoriaPoco, Subcategoria>
{
    private SubcategoriaRepo repositorio;

    public SubcategoriaServico(AtacadoContext ctx) : base(ctx)
    {
        repositorio = new SubcategoriaRepo(ctx);
    }

    public override SubcategoriaPoco Atualizar(SubcategoriaPoco poco)
    {
        Subcategoria tupla = this.Converter(poco);
        Subcategoria alterado = this.repositorio.Update(tupla);
        SubcategoriaPoco alteradoPoco = this.Converter(alterado);
        return alteradoPoco;
    }

    public override SubcategoriaPoco Remover(int chave)
    {
        Subcategoria tupla = this.repositorio.Delete(chave);
        SubcategoriaPoco apagado = this.Converter(tupla);
        return apagado;
    }

    public override SubcategoriaPoco Adicionar(SubcategoriaPoco poco)
    {
        Subcategoria dom = this.Converter(poco);
        Subcategoria novo = this.repositorio.Create(dom);
        SubcategoriaPoco novoPoco = this.Converter(novo);
        return novoPoco;
    }

    public override SubcategoriaPoco Ler(int chave)
    {
        Subcategoria tupla = this.repositorio.Read(chave);
        if (tupla == null)
        {
            return null;
        }
        else
        {
            SubcategoriaPoco poco = this.Converter(tupla);
            return poco;
        }
    }

    public override List<SubcategoriaPoco> Listar()
    {
        return this.repositorio.Read()
            .Select(tupla => this.Converter(tupla))
            .ToList<SubcategoriaPoco>();
    }

    public override SubcategoriaPoco Converter(Subcategoria dom)
    {
        return new SubcategoriaPoco()
        {
            Codigo = dom.Codigo,
            CodigoCategoria = dom.CodigoCategoria,
            Descricao = dom.Descricao,
            Ativo = dom.Ativo,
            DataInclusao = dom.DataInclusao
        };
    }

    public override Subcategoria Converter(SubcategoriaPoco poco)
    {
        return new Subcategoria()
        {
            Codigo = poco.Codigo,
            CodigoCategoria = poco.CodigoCategoria,
            Descricao = poco.Descricao,
            Ativo = poco.Ativo,
            DataInclusao = poco.DataInclusao
        };
    }

    public override List<SubcategoriaPoco> Listar(Expression<Func<Subcategoria, bool>> predicado)
    {
        return this.repositorio.Read(predicado)
            .Select(tupla => this.Converter(tupla))
            .ToList<SubcategoriaPoco>();
    }
}