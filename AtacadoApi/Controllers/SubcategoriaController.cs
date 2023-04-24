using Microsoft.AspNetCore.Mvc;
using Atacado.DB.EF.Database;
using Atacado.Poco;
using Microsoft.EntityFrameworkCore;

namespace AtacadoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubcategoriaController : ControllerBase
{
    [HttpGet]
    public List<SubcategoriaPoco> GetAll([FromServices]AtacadoContext context)
    {
        List<SubcategoriaPoco> list = new List<SubcategoriaPoco>();

        foreach (var item in context.Subcategorias.AsNoTracking().ToList())
        {
            SubcategoriaPoco poco = new SubcategoriaPoco();
            poco.Ativo = item.Ativo;
            poco.Codigo = item.Codigo;
            poco.CodigoCategoria = item.CodigoCategoria;
            poco.DataInclusao = item.DataInclusao;
            poco.Descricao = item.Descricao;
            list.Add(poco);
        }

        return list;
    }
}
