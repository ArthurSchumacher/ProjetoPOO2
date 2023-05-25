using Atacado.DB.EF.Database;
using Atacado.Poco;
using Atacado.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/Atacado/Estoque/")]
public class ProdutoController : BaseController
{
    private ProdutoServico _service;
    
    public ProdutoController() : base()
    {
        _service = new (context);
    }

    [HttpGet("Produtos")]
    public List<ProdutoPoco> GetAll()
    {
        return _service.Listar();
    }

    [HttpGet("Produtos/PorCategoria/{categoriaId}")]
    public List<ProdutoPoco> GetByCategoriaId(int categoriaId)
    {
        return _service.Listar(prod => prod.CodigoCategoria == categoriaId);
    }

    [HttpGet("Produtos/PorSubcategoria/{subcategoriaId}")]
    public List<ProdutoPoco> GetBySubcategoriaId(int subcategoriaId)
    {
        return _service.Listar(prod => prod.CodigoSubcategoria == subcategoriaId);
    }

    [HttpGet("[controller]/{id}")]
    public ProdutoPoco GetById(int id)
    {
        return _service.Ler(id);
    }

    [HttpPost("[controller]")]
    public ProdutoPoco Post([FromBody]ProdutoPoco poco)
    {
        return _service.Adicionar(poco);
    }

    [HttpPut("[controller]")]
    public ProdutoPoco Put([FromBody]ProdutoPoco poco)
    {
        return _service.Atualizar(poco);
    }

    [HttpDelete("[controller]/{chave}")]
    public ProdutoPoco Delete(int chave)
    {
        return _service.Remover(chave);
    }
}