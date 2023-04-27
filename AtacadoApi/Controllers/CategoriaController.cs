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
    public List<CategoriaPoco> GetAll([FromServices]AtacadoContext context)
    {
        CategoriaServico _service = new CategoriaServico(context);

        return _service.Listar();
    }
}
