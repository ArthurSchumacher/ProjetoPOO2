using Atacado.DB.EF.Database;
using Atacado.Poco;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atacado.Service;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    [HttpGet]
    public List<CategoriaPoco> GetAll([FromServices]CategoriaServico service)
    { 
        return service.Listar();
    }

    [HttpGet("{id:int}")]
    public CategoriaPoco GetOne([FromServices]CategoriaServico service, [FromRoute]int id)
    {
        return service.Ler(id);
    }

    [HttpPost]
    public CategoriaPoco CreateOne([FromServices]CategoriaServico service, [FromBody]CategoriaPoco poco)
    {
        return service.Adicionar(poco);
    }

    [HttpPut]
    public CategoriaPoco UpdateOne([FromServices]CategoriaServico service, [FromBody]CategoriaPoco poco)
    {
        return service.Atualizar(poco);
    }

    [HttpDelete("{id:int}")]
    public CategoriaPoco RemoveOne([FromServices]CategoriaServico service, [FromRoute]int id)
    {
        return service.Remover(id);
    }
}
