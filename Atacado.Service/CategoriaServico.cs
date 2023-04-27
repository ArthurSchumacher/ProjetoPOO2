using Atacado.DB.EF.Database;
using Atacado.Poco;
using Atacado.Repository;

namespace Atacado.Service;

public class CategoriaServico : BaseAtacadoContextServico<CategoriaPoco, Categoria>
{
    private CategoriaRepo _repository;

    public CategoriaServico(AtacadoContext context) : base(context)
    {
        _repository = new CategoriaRepo(context);
    }

    public override CategoriaPoco Ler(int id)
    {
        throw new NotImplementedException();
    }

    public override List<CategoriaPoco> Listar()
    {
        return _repository.Read().Select(x => Converter(x)).ToList<CategoriaPoco>();
    }

    public override CategoriaPoco Adicionar(CategoriaPoco obj)
    {
        throw new NotImplementedException();
    }

    public override CategoriaPoco Atualizar(CategoriaPoco obj)
    {
        throw new NotImplementedException();
    }

    public override CategoriaPoco Remover(int id)
    {
        throw new NotImplementedException();
    }

    public override CategoriaPoco Converter(Categoria obj)
    {
        return new CategoriaPoco()
        {
            Codigo = obj.Codigo,
            Descricao = obj.Descricao,
            Ativo = obj.Ativo,
            DataInclusao = obj.DataInclusao
        };
    }

    public override Categoria Converter(CategoriaPoco obj)
    {
        return new Categoria()
        {
            Codigo = obj.Codigo,
            Descricao = obj.Descricao,
            Ativo = obj.Ativo,
            DataInclusao = obj.DataInclusao
        };
    }
}
