using Atacado.Poco;
using Microsoft.AspNetCore.Mvc;
using Atacado.Service;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    private CategoriaServico _service;

    public CategoriaController(CategoriaServico service)
    {
        _service = service;
    }

    [HttpGet]
    public List<CategoriaPoco> GetAll()
    { 
        return _service.Listar();
    }

    [HttpGet("{id:int}")]
    public CategoriaPoco GetOne([FromRoute]int id)
    {
        return _service.Ler(id);
    }

    [HttpPost]
    public CategoriaPoco CreateOne([FromBody]CategoriaPoco poco)
    {
        return _service.Adicionar(poco);
    }

    [HttpPut]
    public CategoriaPoco UpdateOne([FromBody]CategoriaPoco poco)
    {
        return _service.Atualizar(poco);
    }

    [HttpDelete("{id:int}")]
    public CategoriaPoco RemoveOne([FromRoute]int id)
    {
        return _service.Remover(id);
    }
}
