using Atacado.DB.EF.Database;
using Atacado.Poco;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : ControllerBase
{
    [HttpGet]
    public List<CategoriaPoco> GetAll([FromServices]AtacadoContext context)
    {
        List<CategoriaPoco> list = new List<CategoriaPoco>();

        foreach (var item in context.Categorias.AsNoTracking().ToList())
        {
            CategoriaPoco poco = new CategoriaPoco();
            poco.Ativo = item.Ativo;
            poco.Codigo = item.Codigo;
            poco.DataInclusao = item.DataInclusao;
            poco.Descricao = item.Descricao;
            list.Add(poco);
        }

        return list;
    }
}
