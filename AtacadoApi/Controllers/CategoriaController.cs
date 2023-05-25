using Atacado.Poco;
using Microsoft.AspNetCore.Mvc;
using Atacado.Service;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/Atacado/Estoque/")]
public class CategoriaController : BaseController
{
    private CategoriaServico _service;

    public CategoriaController()
    {
        _service = new (context);
    }

    [HttpGet("Categorias")]
    public List<CategoriaPoco> GetAll()
    { 
        return _service.Listar();
    }

    [HttpGet("[controller]/{id:int}")]
    public CategoriaPoco GetOne([FromRoute]int id)
    {
        return _service.Ler(id);
    }

    [HttpPost("[controller]")]
    public CategoriaPoco CreateOne([FromBody]CategoriaPoco poco)
    {
        return _service.Adicionar(poco);
    }

    [HttpPut("[controller]")]
    public CategoriaPoco UpdateOne([FromBody]CategoriaPoco poco)
    {
        return _service.Atualizar(poco);
    }

    [HttpDelete("[controller]/{id:int}")]
    public CategoriaPoco RemoveOne([FromRoute]int id)
    {
        return _service.Remover(id);
    }
}
