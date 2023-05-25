using System.Linq.Expressions;
using Atacado.DB.EF.Database;
using Atacado.Poco;
using Atacado.Repository;

namespace Atacado.Service;

public class ProfissaoServico
    : BaseAtacadoContextServico<ProfissaoPoco, Profissao>
{
    private GenericRepository<Profissao> repositorio;

    public ProfissaoServico(AtacadoContext ctx) : base(ctx)
    {
        this.repositorio = new GenericRepository<Profissao>(ctx);
    }

    public override ProfissaoPoco Atualizar(ProfissaoPoco poco)
    {
        Profissao tupla = Converter(poco);
        Profissao alterado = repositorio.Update(tupla);
        ProfissaoPoco alteradoPoco = Converter(alterado);
        return alteradoPoco;
    }

    public override ProfissaoPoco Remover(int chave)
    {
        Profissao tupla = repositorio.Delete(chave);
        ProfissaoPoco apagado = Converter(tupla);
        return apagado;
    }

    public override ProfissaoPoco Adicionar(ProfissaoPoco poco)
    {
        Profissao dom = Converter(poco);
        Profissao novo = repositorio.Create(dom);
        ProfissaoPoco novoPoco = Converter(novo);
        return novoPoco;
    }

    public override ProfissaoPoco Ler(int chave)
    {
        Profissao tupla = repositorio.Read(chave);
        if (tupla == null)
        {
            return null;
        }
        else
        {
            ProfissaoPoco poco = Converter(tupla);
            return poco;
        }
    }

    public override List<ProfissaoPoco> Listar()
    {
        return repositorio.Read()
            .Select(tupla => this.Converter(tupla))
            .ToList<ProfissaoPoco>();
    }

    public override ProfissaoPoco Converter(Profissao dom)
    {
        return new ProfissaoPoco()
        {
            ProfissaoID = dom.ProfissaoID,
            Descricao = dom.Descricao,
            DataInsert = dom.DataInsert,
            Ativo = dom.Ativo
        };
    }

    public override Profissao Converter(ProfissaoPoco poco)
    {
        return new Profissao()
        {
            ProfissaoID = poco.ProfissaoID,
            Descricao = poco.Descricao,
            DataInsert = poco.DataInsert,
            Ativo = poco.Ativo
        };
    }

    public override List<ProfissaoPoco> Listar(Expression<Func<Profissao, bool>> predicado)
    {
        return repositorio.Read(predicado)
            .Select(tupla => this.Converter(tupla))
            .ToList<ProfissaoPoco>();
    }
}